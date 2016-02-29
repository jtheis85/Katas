var expect = require('expect');

var testString = "The rain in Spain lies mainly on the plain.";

// Old school
expect(testString.charAt(0)).toBe('T');
expect(testString.charAt(testString.length - 1)).toBe('.');

for(var i = 0; i < testString.length; i++) {
    console.log(testString.charAt(i));
}

// ES5
expect(testString[0]).toBe('T');
expect(testString[testString.length - 1]).toBe('.');


for(var j = 0; j < testString.length; j++) {
    console.log(testString[j]);
}