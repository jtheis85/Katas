'use strict';

var expect = require('expect');

var testString = "The rain in Spain lies mainly on the plain.";

// Not sure why this works. "includes" is supposed to be an ES6 thing
expect(testString.endsWith('on the plain.')).toBe(true);

// A fake polyfill using a different name
if(!String.prototype.doesEndWith) {
    String.prototype.doesEndWith = function (search) {
        // The search string can't be longer than the string being searched in
        if (this.length < search.length)
            return false;
        else {
            var position = this.length - search.length;
            var index = this.indexOf(search, position);
            return index !== -1 && index === position;
        }
    }
}

expect(testString.doesEndWith('on the plain.')).toBe(true);
expect(testString.doesEndWith('on the plain')).toBe(false);

var testString2 = "the rain the rain";

expect(testString2.doesEndWith('the rain')).toBe(true);