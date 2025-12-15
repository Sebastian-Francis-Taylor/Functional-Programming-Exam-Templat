// 1.1
let foo = printfn "bar"

// 1.2
let myFunction = printfn "Hello Exam time"

let test x =
    match x with
    | 1 -> printfn "foo"
    | _ -> printfn "bar"

let rec foldBack op list e =
    match list with
    | [] -> e
    | (x :: xs) -> op x (foldBack op xs e)
