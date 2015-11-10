function quicksort(array, lo, hi) {
    if(lo < hi) {
        // Pick a pivot
        var pivot = array[hi];

        // Partition
        var i = lo;
        for(var j = lo; j < hi; j++) {
            if (array[j] <= pivot) {
                swap(array, i, j);
                i++;
            }
        }
        swap(array, i, hi);

        quicksort(array, lo, i-1);
        quicksort(array, i+1, hi);
    }
}

function swap(array, first, second) {
    var temp = array[first];
    array[first] = array[second];
    array[second] = temp;
}



//var values = [5,4,3,2,1];
var values = [2,3,1,5,4];
var before = values.concat();
quicksort(values, 0, values.length - 1);
var after  = values.concat();
alert("Before: " + before + "\n" + "After: " + after);