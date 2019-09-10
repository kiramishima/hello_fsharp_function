namespace HelloFunctions

open Microsoft.Azure.WebJobs
open Microsoft.AspNetCore.Mvc
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
// open Microsoft.Azure.WebJobs.Host
open Microsoft.Extensions.Logging
open System.IO
open System.Text

module Function1 =
    let Say name =
        printfn "Hello %s" name

    [<FunctionName("HelloFunction")>]
    let Run([<HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)>] req : HttpRequest, log: ILogger) =
        log.LogInformation("F# HTTP trigger function processed a request.")
        OkObjectResult "Nino Nino"



