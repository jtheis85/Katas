var expect = require('expect');

Array.prototype.clone = function() {
    // This is equivalent to slice(0, this.length);
    return this.slice();
};

Array.prototype.tail = function(count) {
    return this.slice(arr.length - count);
};

Array.prototype.head = function(count) {
    return this.slice(0, count);
};
Array.prototype.inner = function(first, last) {
    return this.slice(first, last + 1);
};
Array.prototype.bracket = function(fromBeginning, fromEnd) {
    return this.slice(fromBeginning, -1 * fromEnd);
};

var value;
var arr = [1,2,3,4];

//  Clone Tests
value = arr.clone();
// Should be a new array pointing to the same items
expect(value).toNotBe(arr);
expect(value).toEqual(arr);

// Tail Tests
value = arr.tail(2);
expect(value.length).toBe(2);
expect(value[0]).toBe(arr[2]);
expect(value[1]).toBe(arr[3]);

// Head Tests
value = arr.head(2);
expect(value.length).toBe(2);
expect(value[0]).toBe(arr[0]);
expect(value[1]).toBe(arr[1]);

// Inner tests
value = arr.inner(1,2);
expect(value.length).toBe(2);
expect(value[0]).toBe(arr[1]);
expect(value[1]).toBe(arr[2]);

// Bracket tests
value = arr.bracket(1,1);
expect(value.length).toBe(2);
expect(value[0]).toBe(arr[1]);
expect(value[1]).toBe(arr[2]);

value = arr.bracket(1,2);
expect(value.length).toBe(1);
expect(value[0]).toBe(arr[1]);

value = arr.bracket(1,3);
expect(value.length).toBe(0);

value = arr.bracket(1,4);
expect(value.length).toBe(0);