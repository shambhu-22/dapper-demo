# Dapper sample project in .Net Core Web API
## Why to use it?
### Dapper ORM is used to use pure SQL for Querying, filtering etc. CRUD operations where it is better than entity framework core for highly scalable(millions of users) applications.

### Why it's better ?
1. It uses pure SQL queries which are easy to improve on performance v/s EFCore first translates code into TSQL query
and runs into SQL which can also be improved in performance using Execution plans etc. but it doesn't always suggest
correct ways to improve performance, while SQL has tools to identify & improve the query.
2. Why do filtering in C# if you can in Database using Dapper v/s loading huge data in memory from SQL server and apply filters over that & reduce performance in EF Core.
3. Risk in EFCore: Rollback migrations cause permanent loss of data later if not carefully made before scaling, EF Core seems simpler but the DB Schema it generates need careful planning otherwise in big production datasets it might cause huge server costs of unused unnecessary resources. Thus it requires good trained developers.
4. Gives upfront scalability readiness to application from database side

# Summary: Use Dapper for highly scalable apps, EFCore works fine/great for small user base applcations.