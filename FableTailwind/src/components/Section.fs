module Section

open Elmish
open Elmish.React
open Elmish.HMR
open Feliz
open Tailwind

open type prop
open type Html

let Section (content: ReactElement) =
    div[
        className [tw.``w-04/05``]
        children[
            content
        ]
    ]