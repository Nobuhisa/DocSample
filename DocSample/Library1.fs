namespace DocSample

module Sample =
    /// あいさつ関数です。
    let hello () = printfn "hello, world"

    /// サンプルクラスです。
    type Sample() =
        /// サンプルメソッドです。
        member this.Sample () = printfn "F#!F#!"