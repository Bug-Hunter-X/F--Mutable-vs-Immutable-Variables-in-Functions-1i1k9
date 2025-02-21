let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 as expected

let swap2 x y = 
    let temp = x
    x <- y
    y <- temp

let z = 10
let w = 20
let (z,w) = swap2 z w //This will give error because swap2 does not work with immutable values
printf "%d %d" z w