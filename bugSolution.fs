let rec loop x y =
    if x = 1000000 then
        printfn "%d %d" x y
    else
        loop (x + 1) (y + 1)

loop 0 0