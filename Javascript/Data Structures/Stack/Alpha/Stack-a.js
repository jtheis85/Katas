function Stack() {

    var data = [];
    var top = -1;

    this.push = function(value) {
        data.length++;
        data[++top] = value;
    };
    this.pop = function() {
        var value = data[top--];
        data.length--;
        return value;
    };
}

(function test1() {
    var stack = new Stack();
    stack.push(1);
    var value = stack.pop();

    if(value === 1)
        console.log("test1 Passed");
    else
        console.log("test1 Failed");
})();

(function test2() {
    var stack = new Stack();
    stack.push(1);
    stack.push(2);

    var value1 = stack.pop();
    var value2 = stack.pop();

    if(value1 === 2 && value2 === 1)
        console.log("test2 Passed");
    else
        console.log("test2 Failed");
})();

(function test3() {
    var stack1 = new Stack();
    stack1.push(1);

    var stack2 = new Stack();
    stack2.push(2);

    var value1 = stack1.pop();
    var value2 = stack2.pop();

    if(value1 === 1 && value2 === 2)
        console.log("test3 Passed");
    else
        console.log("test3 Failed");
})();