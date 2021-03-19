module Page

open Elmish
open Elmish.React
open Elmish.HMR
open Feliz
open Tailwind

open type prop
open type Html


let Page (content : ReactElement) =
    div[
        className [tw.``justify-center``; tw.``w-full``; tw.``h-full``]
        children[
            content
        ]
    ]