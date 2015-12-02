// Finds the nth Fibonacci digit, where the sequence begins with 0,1,...
// Done recursively
function fibonacci(n) {
    if(n === 0)
        return 0;
    else if(n === 1)
        return 1;
    else
        return fibonacci(n-2) + fibonacci(n-1);
}

for(var i = 0; i < 20; i++) {
    console.log(fibonacci(i));
}