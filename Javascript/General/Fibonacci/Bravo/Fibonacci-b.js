// Returns the nth Fibonacci digit, based on the sequence starting with 0,1,...
// Done iteratively rather than recursively
function fibonacci(n) {
    if(n === 0)
        return 0;
    if(n === 1)
        return 1;

    var n2 = 0;
    var n1 = 1;
    var value;
    for(var i = 0; i < n - 1; i++) {
        value = n2 + n1;
        n2 = n1;
        n1 = value;
    }
    return value;
}

for(var i = 0; i < 20; i++) {
    console.log(fibonacci(i));
}