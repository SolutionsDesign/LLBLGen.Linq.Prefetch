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

There is full support for filtering, ordering & limiting on entity collection properties within a prefetch expression by using:-
* Filter
* OrderBy
* OrderByDescending
* Limit

It is also possible to explicitly include or exclude certain fields on entity & entity collection properties within a prefetch expression by using:-
* Include
* Exclude
