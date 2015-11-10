function reverse(array) {
    for(var i = 0; i < array.length/2; i++) {
        // Item near the beginning
        var temp = array[i];
        // Replace the item at the beginning with the item at the end
        array[i] = array[array.length - i - 1];
        // Replace the item at the end with the saved item at the beginning
        array[array.length - i - 1] = temp;
    }
}

var values = [6,5,4,3,2,1];
var before =  values.join();
reverse(values);
var after = values.join();

alert("Before: " + before + "\n" + "After: " + after);