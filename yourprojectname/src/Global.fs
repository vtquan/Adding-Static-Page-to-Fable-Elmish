module Global

type Page =
    | Home
    | Counter
    | About
    | NewPage

let toHash page =
    match page with
    | About -> "#about"
    | Counter -> "#counter"
    | Home -> "#home"
    | NewPage -> "#newpage"
