module FukushuCaml.Expr1


type Expr19 =
    | Var of string
    | IntV of int
    | Add of Expr19 * Expr19
    | Mul of Expr19 * Expr19

let rec eval (env: Map<string, int>) (expr: Expr19) : int =
    match expr with
    | Var x ->
        match env.TryFind x with
        | Some v -> v
        | None -> failwithf "Variable %s not found" x
    | IntV v -> v
    | Add(expr1, expr2) -> eval env expr1 + eval env expr2
    | Mul(expr1, expr2) -> eval env expr1 * eval env expr2

// 3 + 2 * x
let expr = Add(IntV 3, Mul(Var "x", IntV 2))

// 4 * x + 3
let expr4 = Add(Mul(Var "x", IntV 4), IntV 3)

let env = Map.ofList [ ("x", 4) ]

let result = eval env expr

[<EntryPoint>]
let main argv =
    printfn "The result of the expression is %d" result
    0
