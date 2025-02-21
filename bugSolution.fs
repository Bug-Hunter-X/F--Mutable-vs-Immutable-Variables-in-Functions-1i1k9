let swap x y =
    let temp = x
    x <- y
    y <- temp

let swap2 x y = 
    (y,x)

let z = 10
let w = 20
let (z,w) = swap2 z w
printf "%d %d" z w //This will print 20 10 as expected