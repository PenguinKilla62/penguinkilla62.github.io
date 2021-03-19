module App

(**
 The famous Increment/Decrement ported from Elm.
 You can find more info about Elmish architecture and samples at https://elmish.github.io/
*)

open Elmish
open Elmish.React
open Elmish.HMR
open Feliz

open Tailwind
// MODEL

type Model = int

type Msg =
| Increment
| Decrement

let init() : Model = 0

// UPDATE

let update (msg:Msg) (model:Model) =
    match msg with
    | Increment -> model + 1
    | Decrement -> model - 1

// VIEW (rendered with React)



let view (model:Model) dispatch =

  Html.div [
    prop.classes [
      tw.container
      tw.``mx-auto``
    ]

    prop.children [

      // Header row
      Html.div [
        prop.classes [
          tw.``text-3xl``
          tw.``mb-01``
          tw.``text-purple-800``
        ]
        prop.text "Counter (tailwind)"
      ]

      // Counter row
      Html.div [
        prop.classes [
          tw.flex
          tw.``flex-col``
          tw.``items-center``
          tw.``wide:flex-row-reverse``
          tw.``wide:justify-around``
        ]

        prop.children [

          Html.button [
            prop.classes [
              tw.``custom-blue-button``
              tw.``w-02/05``
              tw.``wide:w-01/06``
              tw.``transition-colors``
              tw.``duration-200``
            ]
            prop.onClick (fun _ -> dispatch Increment)
            prop.text "+"
          ]

          Html.div [
            prop.classes [
              tw.``text-3xl``
              tw.``text-teal-600``
              tw.``text-center``
              tw.``w-01/06``
            ]
            prop.text model
          ]

          Html.button [
            prop.classes [
              tw.``custom-blue-button``
              tw.``w-02/05``
              tw.``wide:w-01/06``
              tw.``transition-colors``
              tw.``duration-200``
            ]
            prop.onClick (fun _ -> dispatch Decrement)
            prop.text "-"
          ]

        ]
      ]

    ]
  ]

// App
Program.mkSimple init update view
|> Program.withReactSynchronous "elmish-app"
|> Program.run
