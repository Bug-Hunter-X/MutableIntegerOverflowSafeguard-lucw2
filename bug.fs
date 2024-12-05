let mutable x = 0
let mutable y = 0

let rec loop () =
    x <- x + 1
    y <- y + 1
    if x = 1000000 then
        printfn "%d %d" x y
    else
        loop ()

loop ()