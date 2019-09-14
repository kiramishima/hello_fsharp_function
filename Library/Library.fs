namespace HelloFunctions

open Microsoft.Azure.WebJobs
open Microsoft.AspNetCore.Mvc
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Logging
open System.IO
open System.Text

module MyFunction =
    let Say name =
        printfn "Hello %s" name

    // Nombre de la funcion
    [<FunctionName("MyFunction")>]
    // Nivel de Autorizacion para consumir la funcion, la cambiamos a Anonymous ya que para este ejemplo no requerimos nada de seguridad
    // Tambien que metodos HTTP acepta
    // Route nos permite customizar el nombre de salida al publicar la funcion
    let Run([<HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)>] req : HttpRequest, log: ILogger) =
        log.LogInformation("F# HTTP trigger function processed a request.")
        OkObjectResult "This is an example of Azure Function with F#"



