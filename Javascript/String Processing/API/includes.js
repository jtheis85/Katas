'use strict';

var expect = require('expect');

var testString = "The rain in Spain lies mainly on the plain.";

// Not sure why this works. "includes" is supposed to be an ES6 thing
expect(testString.includes('Spain')).toBe(true);

// A fake polyfill using a different name
if(!String.prototype.hasSubstring) {
    String.prototype.hasSubstring = function (search, start) {
        // Fix the start parameter if it is not supplied correctly
        if (typeof start !== 'number') {
            start = 0;
        }

        // The string can't be found if it is too long or we start too close to the end
        if(start + search.length > this.length) {
            return false;
        }
        else {
            return this.indexOf(search, start) !== -1;
        }
    };
}

expect(testString.hasSubstring('rain in Spain')).toBe(true);
expect(testString.hasSubstring('in spain lies')).toBe(false);