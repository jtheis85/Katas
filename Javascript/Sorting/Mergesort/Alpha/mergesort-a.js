function mergesort(array) {
    if(array.length === 1)
        return array;

    //divide
    var left = array.slice(0, Math.floor(array.length/2));
    var right = array.slice(Math.floor(array.length/2), array.length);

    //merge
    return merge(mergesort(left), mergesort(right));
}

function merge(left, right) {
    var result = [];
    var li = 0;
    var ri = 0;

    while(li < left.length && ri < right.length) {
        if(left[li] < right[ri])
            result.push(left[li++]);
        else
            result.push(right[ri++]);
    }

    return result.concat(left.slice(li)).concat(right.slice(ri));
}

//var values = [5,4,3,2,1];
var values = [2,3,1,5,4];
var before = values.join();
var after  = mergesort(values).join();
alert("Before: " + before + "\n" + "After: " + after);