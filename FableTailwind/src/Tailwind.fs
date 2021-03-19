module Tailwind

open Zanaptak.TypedCssClasses

// Naming.Verbatim required for PurgeCSS bundle reduction -- https://tailwindcss.com/docs/controlling-file-size
type tw =
  CssClasses<
    "content/tailwind-source.css"
    , Naming.Verbatim
    , commandFile = "node"
    , argumentPrefix = "tailwind-process.js tailwind.config.js"
    //, logFile = "TypedCssClasses.log" // uncomment to enable logging
  >