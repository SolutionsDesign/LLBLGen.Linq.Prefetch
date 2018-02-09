# LLBLGen.Linq.Prefetch
Prefetch extensions for the Linq Provider in LLBLGen.

## What is it?
Each time you build prefetches for LLBLGen Linq queries the syntax can be a bit much.  These extensions add some simplified prefetch building logic.

Instead of

    metaData.Project
        .WithPath(path => path.Prefetch<ProjectCompanyLinkEntity>(p => p.ProjectCompanyLinks)
            .SubPath(subPath1 => subPath1.Prefetch<CompanyEntity>(pcl => pcl.Company)
                .SubPath(subPath2 => subPath2.Prefetch<CompanyAddressEntity>(c => c.CompanyAddresses)))
            .SubPath(subPath1 => subPath1.Prefetch<ContactEntity>(Pcl => pcl.Contact)
                .SubPath(subPath2 => subPath2.Prefetch<ContactTypeEntity>(c => c.ContactType))));
            
You can just write

    metaData.Project
        .With(p => p.ProjectCompanyLinks
                    .With(pcl => pcl.Company
                                    .With(c => c.CompanyAddresses),
                          pcl => pcl.Contact.ContactType));

## Filtering, Ordering, Limiting, Including & Excluding

There is full support for filtering, sorting and explicit inclusion or exclusion of fields on entity and entity collection properties within a prefetch expression by using:-
* FilterBy
* SortBy
* SortByDescending
* Include
* Exclude

It is also possible to limit the number of rows from an entity collection properties within a prefetch expression by using:-
* LimitTo

## Installing
It's recommended that you simply download [the single file](https://github.com/SolutionsDesign/LLBLGen.Linq.Prefetch/blob/master/LLBLGen.Linq.Prefetch/PrefetchExtensions.cs) 
of this project and add it to your project manually. There aren't many changes expected to this file, it won't be updated frequently. If you want to, you can
also install the file as a compiled dll, see the nuget reference below. This has the downside that with a newer release of the ORMSupportClasses, it might be this
library isn't updated and you get version conflicts. 

## Tests

The test suite included in the source is based on the standard Northwind database tests from LLBLGen Pro and is included with kind permission.

## Other business

Check this out on Nuget: https://www.nuget.org/packages/LLBLGen.Linq.Prefetch

## Special thanks
This library was originally written by Richard Hopton.