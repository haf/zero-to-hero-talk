#r "packages/Suave/lib/net40/Suave.dll"

open System
open System.Text
open Suave
open Suave.Successful


let app: WebPart =
  request (fun r ->
    let sb = StringBuilder ()
    let app (text: string) (sb: StringBuilder) = sb.Append text
    let appnl (text: string) (sb: StringBuilder) = sb.Append text |> ignore; sb.AppendLine()
    let heading name = sprintf "# %s" name, ""

    [ yield heading "Headers"
      for key, value in r.headers do
        yield key, value

      let form = r.form |> List.filter (fst >> (<>) "") // #618
      if List.length form > 0 then
        yield heading "Form data"
        for key, value in form do
          match value with
          | None ->
            yield key, ""
          | Some value ->
            yield key, ""

      if List.length r.multiPartFields > 0 then
        yield heading "Multipart fields"
        for key, value in r.multiPartFields do
          yield key, value

      if Array.length r.rawForm > 0 then
        yield heading "Body"
        yield "", UTF8.toString r.rawForm
    ]
    |> List.fold (fun sb (key, value) ->
        sb
        |> app key
        |> app ": "
        |> appnl value)
        (StringBuilder())
    |> sprintf "%O"
    |> OK
  )

let config =
  { defaultConfig with bindings = [ HttpBinding.createSimple HTTP "127.0.0.1" 8002 ] }

startWebServer config app