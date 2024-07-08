open System

// 関数の定義
let add x y = x + y

// レコード型の定義
type Person = { Name: string; Age: int }

// 条件分岐の例
let ageCheck age =
    if age < 18 then "You are a minor." else "You are an adult."

// リスト操作の例
let numbers = [ 1; 2; 3; 4; 5 ]
let sum = List.sum numbers

// ループの例
let printNumbers numbers =
    for number in numbers do
        printfn "%d" number

[<EntryPoint>]
let main argv =
    // 変数の宣言と代入
    let x = 10
    let y = 20
    let result = add x y
    printfn "The result of adding %d and %d is %d" x y result

    // レコードの作成と使用
    let person = { Name = "Alice"; Age = 30 }
    printfn "Person: Name = %s, Age = %d" person.Name person.Age

    // 条件分岐の使用
    let ageMessage = ageCheck person.Age
    printfn "%s" ageMessage

    // リスト操作の使用
    printfn "The sum of the list is %d" sum
    printNumbers numbers

    // 終了コードを返す
    0
