using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NUnit.Framework;
using NW26.DatabaseSpecific;
using NW26.EntityClasses;
using NW26.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGen.Linq.Prefetch.Tests
{
    /// <summary>
    /// Unit tests for entity oriented fetches, into entity collections or lists of entities.
    /// </summary>
    [TestFixture]
    public class PrefetchExtensionsTests
    {
        [Test]
        public void GetAllCustomersWithTheirRelatedOrders()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = (from c in metaData.Customer
                         where !(new[] {"FISSA", "PARIS"}.Contains(c.CustomerId))
                         select c).With(c => c.Orders);

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    Assert.IsTrue(v.Orders.Count > 0);
                }
                Assert.AreEqual(89, count);
            }
        }

        [Test]
        public void GetAllCustomersWithTheirRelatedOrdersAndEmployeesUsingContext()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var contextToUse = new Context();
                metaData.ContextToUse = contextToUse;

                // use a query which fetches Employees through orders into the customers and employee through order.
                // the employee entity instances in the m:n collection should be the same as the ones referenced through the order instances.
                var q = (from c in metaData.Customer
                         where c.Country == "Germany"
                         select c).With(c => c.Orders.With(o => o.Employee),
                                        c => c.EmployeeCollectionViaOrder);

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    // use object instance compare with linear search, otherwise we could get false positives as Equals and GetHashCode are tied to
                    // the PK values of the entities, which obviously are equal.
                    Assert.IsTrue(v.Orders.Count > 0);
                    foreach (var o in v.Orders)
                    {
                        // traverse the employees in v.Employees and do an object instance compare. Has to be there
                        var found = v.EmployeeCollectionViaOrder.Any(e => e == o.Employee);
                        Assert.IsTrue(found);
                    }
                }
                Assert.AreEqual(11, count);
            }
        }

        [Test]
        public void GetAllCustomersWithTheirRelatedOrdersWhichAreHandledByEmployee3()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = (from c in metaData.Customer
                         select c).With(c => c.Orders.FilterBy(o => o.EmployeeId == 3));

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    if (v.Orders.Count > 0)
                    {
                        foreach (var o in v.Orders)
                        {
                            Assert.AreEqual(3, o.EmployeeId);
                        }
                    }
                }
                Assert.AreEqual(91, count);
            }
        }

        [Test]
        public void GetAllCustomersWithTheirRelatedOrdersInQueryVariant()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = from c in metaData.Customer.With(c => c.Orders)
                        where !(new[] {"FISSA", "PARIS"}.Contains(c.CustomerId))
                        select c;

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    Assert.IsTrue(v.Orders.Count > 0);
                }
                Assert.AreEqual(89, count);
            }
        }

        [Test]
        public void GetAllCustomersFromGermanyWithTheirOrdersAndRelatedEmployeeAndOrderDetailsWithExcludedFields()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = (from c in metaData.Customer
                         where c.Country == "Germany"
                         select c).With(c => c.Orders.With(o => o.OrderDetails,
                                                           o => o.Employee.Exclude(e => e.Photo, e => e.Notes)));

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    Assert.IsTrue(v.Orders.Count > 0);
                    foreach (var o in v.Orders)
                    {
                        Assert.IsNotNull(o.Employee);
                        Assert.IsTrue(o.OrderDetails.Count > 0);
                    }
                }
                Assert.AreEqual(11, count);
            }
        }

        [Test]
        public void GetAllCustomersWithTheirLast2Orders()
        {
            using (var adapter = new DataAccessAdapter())
            {
                adapter.ParameterisedPrefetchPathThreshold = 1;
                var metaData = new LinqMetaData(adapter);
                var q = (from c in metaData.Customer
                         where !(new[] {"FISSA", "PARIS"}.Contains(c.CustomerId))
                         select c).With(c => c.Orders.OrderByDescending(o => o.OrderDate)
                                              .LimitTo(2));

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    Assert.IsTrue((v.Orders.Count > 0) && (v.Orders.Count <= 2));
                }
                Assert.AreEqual(89, count);
            }
        }

        [Test]
        public void GetAllCustomersWithTheirLast2OrdersFiledByEmployee2()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = (from c in metaData.Customer
                         where !(new[] {"FISSA", "PARIS"}.Contains(c.CustomerId))
                         select c).With(c => c.Orders.FilterBy(o => o.EmployeeId == 2)
                                              .OrderByDescending(o => o.OrderDate)
                                              .LimitTo(2));

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    Assert.IsTrue((v.Orders.Count >= 0) && (v.Orders.Count <= 2));
                    if (v.Orders.Count > 0)
                    {
                        foreach (var o in v.Orders)
                        {
                            Assert.AreEqual(2, o.EmployeeId);
                        }
                    }
                }
                Assert.AreEqual(89, count);
            }
        }

        [Test]
        public void GetAllCustomersWithTheirLast2OrdersWithSubPaths()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = (from c in metaData.Customer
                         where !(new[] {"FISSA", "PARIS"}.Contains(c.CustomerId))
                         select c).With(c => c.Orders.OrderByDescending(o => o.OrderDate)
                                              .LimitTo(2)
                                              .With(o => o.OrderDetails,
                                                    o => o.Employee));

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    Assert.IsTrue((v.Orders.Count > 0) && (v.Orders.Count <= 2));
                    if (v.Orders.Count > 0)
                    {
                        foreach (var o in v.Orders)
                        {
                            Assert.IsTrue(o.OrderDetails.Count > 0);
                            Assert.IsNotNull(o.Employee);
                        }
                    }
                }
                Assert.AreEqual(89, count);
            }
        }

        /// <summary>
        /// Fetches a multi-branch prefetch path: territory m:n employee 1:n Order and employee m:n customer 1:n order.
        /// </summary>
        [Test]
        public void GetTerritoriesWithEmployeesAndCustomersOrdersInComplexPath()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = (from t in metaData.Territory
                         select t)
                    .With(t => t.EmployeeCollectionViaEmployeeTerritory
                                .With(e => e.Orders,
                                      e => e.CustomerCollectionViaOrder.With(c => c.Orders)));

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    if (new[] {"29202", "72716", "75234", "78759"}.Contains(v.TerritoryId))
                    {
                        // territory has no employees
                        continue;
                    }
                    Assert.IsTrue(v.EmployeeCollectionViaEmployeeTerritory.Count > 0);
                    foreach (var e in v.EmployeeCollectionViaEmployeeTerritory)
                    {
                        Assert.IsTrue(e.Orders.Count > 0);
                        Assert.IsTrue(e.CustomerCollectionViaOrder.Count > 0);
                        foreach (var c in e.CustomerCollectionViaOrder)
                        {
                            if (!(new[] {"FISSA", "PARIS"}.Contains(c.CustomerId)))
                            {
                                Assert.IsTrue(c.Orders.Count > 0);
                            }
                        }
                    }
                }
                Assert.AreEqual(53, count);
            }
        }

        [Test]
        public void GetSingleCustomerWithRelatedOrders()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = (from c in metaData.Customer
                         select c).With(c => c.Orders)
                                  .Single(c => c.CustomerId == "CHOPS");

                Assert.AreEqual("CHOPS", q.CustomerId);
                Assert.IsTrue(q.Orders.Count > 0);
            }
        }

        [Test]
        public void GetOrdersWithRelatedCustomersIfCustomerStartsWithC()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = (from o in metaData.Order
                         where o.EmployeeId == 3
                         select o).With(o => o.Customer.FilterBy(c => c.CustomerId.StartsWith("C")));
                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    if (v.CustomerId.StartsWith("C"))
                    {
                        Assert.IsNotNull(v.Customer);
                        Assert.AreEqual(v.CustomerId, v.Customer.CustomerId);
                    }
                    else
                    {
                        Assert.IsNull(v.Customer);
                    }
                }
                Assert.AreEqual(127, count);
            }
        }

        [Test]
        public void GetOrderDetailsWithOrderSortedOnCustomerRelatedToOrder()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = (from od in metaData.OrderDetail
                         where od.ProductId > 10
                         select od).With(od => od.Order.OrderBy(o => o.Customer.Country));

                int count = q.ToArray().Count();
                Assert.AreEqual(1939, count);
            }
        }

        [Test]
        public void GetCustomerWithRelatedOrdersSortedByFieldAndLimit()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var q = (from c in metaData.Customer
                         where c.CustomerId == "ALFKI"
                         select c)
                    .With(c => c.Orders.OrderBy(o => o.Freight)
                                .LimitTo(2));

                foreach (var v in q)
                {
                    Assert.IsTrue(v.Orders.Count <= 2);
                    Assert.AreEqual("ALFKI", v.CustomerId);
                }
            }
        }

        [Test]
        public void GetTerritoriesWithEmployeesAndCustomersOrdersInComplexPathUsingArrayConstantPaths()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var paths = new Expression<Func<EmployeeEntity, Object>>[]
                {
                    e => e.Orders,
                    e => e.CustomerCollectionViaOrder.With(c => c.Orders)
                };
                var q = (from t in metaData.Territory
                         select t)
                    .With(t => t.EmployeeCollectionViaEmployeeTerritory
                                .With(paths));

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    if (new[] {"29202", "72716", "75234", "78759"}.Contains(v.TerritoryId))
                    {
                        // territory has no employees
                        continue;
                    }
                    Assert.IsTrue(v.EmployeeCollectionViaEmployeeTerritory.Count > 0);
                    foreach (var e in v.EmployeeCollectionViaEmployeeTerritory)
                    {
                        Assert.IsTrue(e.Orders.Count > 0);
                        Assert.IsTrue(e.CustomerCollectionViaOrder.Count > 0);
                        foreach (var c in e.CustomerCollectionViaOrder)
                        {
                            if (!(new[] {"FISSA", "PARIS"}.Contains(c.CustomerId)))
                            {
                                Assert.IsTrue(c.Orders.Count > 0);
                            }
                        }
                    }
                }
                Assert.AreEqual(53, count);
            }
        }

        [Test]
        public void GetTerritoriesWithEmployeesAndCustomersOrdersInComplexPathUsingMixedInlinePaths()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                Expression<Func<EmployeeEntity, object>> employeeOrdersPath = e => e.Orders;
                var q = (from t in metaData.Territory
                         select t)
                    .With(t => t.EmployeeCollectionViaEmployeeTerritory
                                .With(employeeOrdersPath,
                                      GetCustomerCollectionViaOrderWithOrdersPath(false).First()));

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    if (new[] {"29202", "72716", "75234", "78759"}.Contains(v.TerritoryId))
                    {
                        // territory has no employees
                        continue;
                    }
                    Assert.IsTrue(v.EmployeeCollectionViaEmployeeTerritory.Count > 0);
                    foreach (var e in v.EmployeeCollectionViaEmployeeTerritory)
                    {
                        Assert.IsTrue(e.Orders.Count > 0);
                        Assert.IsTrue(e.CustomerCollectionViaOrder.Count > 0);
                        foreach (var c in e.CustomerCollectionViaOrder)
                        {
                            if (!(new[] {"FISSA", "PARIS"}.Contains(c.CustomerId)))
                            {
                                Assert.IsTrue(c.Orders.Count > 0);
                            }
                        }
                    }
                }
                Assert.AreEqual(53, count);
            }
        }

        [Test]
        public void GetTerritoriesWithEmployeesAndCustomersOrdersInComplexPathUsingEnumerableConstantPaths()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var paths = GetCustomerCollectionViaOrderWithOrdersPath(true);
                var q = (from t in metaData.Territory
                         select t)
                    .With(t => t.EmployeeCollectionViaEmployeeTerritory
                                .With(paths));

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    if (new[] {"29202", "72716", "75234", "78759"}.Contains(v.TerritoryId))
                    {
                        // territory has no employees
                        continue;
                    }
                    Assert.IsTrue(v.EmployeeCollectionViaEmployeeTerritory.Count > 0);
                    foreach (var e in v.EmployeeCollectionViaEmployeeTerritory)
                    {
                        Assert.IsTrue(e.Orders.Count > 0);
                        Assert.IsTrue(e.CustomerCollectionViaOrder.Count > 0);
                        foreach (var c in e.CustomerCollectionViaOrder)
                        {
                            if (!(new[] {"FISSA", "PARIS"}.Contains(c.CustomerId)))
                            {
                                Assert.IsTrue(c.Orders.Count > 0);
                            }
                        }
                    }
                }
                Assert.AreEqual(53, count);
            }
        }

        [Test]
        public void GetTerritoriesWithEmployeesAndCustomersOrdersInComplexPathUsingMethodCallPaths()
        {
            using (var adapter = new DataAccessAdapter())
            {
                const bool yieldOrders = true;
                var metaData = new LinqMetaData(adapter);
                var q = (from t in metaData.Territory
                         select t)
                    .With(t => t.EmployeeCollectionViaEmployeeTerritory
                                .With(GetCustomerCollectionViaOrderWithOrdersPath(yieldOrders)));

                int count = 0;
                foreach (var v in q)
                {
                    count++;
                    if (new[] {"29202", "72716", "75234", "78759"}.Contains(v.TerritoryId))
                    {
                        // territory has no employees
                        continue;
                    }
                    Assert.IsTrue(v.EmployeeCollectionViaEmployeeTerritory.Count > 0);
                    foreach (var e in v.EmployeeCollectionViaEmployeeTerritory)
                    {
                        Assert.IsTrue(e.Orders.Count > 0);
                        Assert.IsTrue(e.CustomerCollectionViaOrder.Count > 0);
                        foreach (var c in e.CustomerCollectionViaOrder)
                        {
                            if (!(new[] {"FISSA", "PARIS"}.Contains(c.CustomerId)))
                            {
                                Assert.IsTrue(c.Orders.Count > 0);
                            }
                        }
                    }
                }
                Assert.AreEqual(53, count);
            }
        }

        private static IEnumerable<Expression<Func<EmployeeEntity, object>>> GetCustomerCollectionViaOrderWithOrdersPath(Boolean yieldOrders)
        {
            if (yieldOrders)
                yield return e => e.Orders;
            yield return e => e.CustomerCollectionViaOrder.With(c => c.Orders);
        }

        [TestFixtureSetUp]
        public void SetupTests()
        {
            Console.WriteLine("{0}.{1}", RuntimeLibraryVersion.Version, RuntimeLibraryVersion.Build);
        }
    }
}