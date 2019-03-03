module NewInfo.View

open Fable.Helpers.React
open Fable.Helpers.React.Props

let root =
  div
    [ ClassName "content" ]
    [ h1
        [ ]
        [ str "New page" ]
      p
        [ ]
        [ str "You created a new page" ] ]