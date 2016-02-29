var expect = require('expect');

var testString1 = "The rain in Spain ";
var testString2 = "lies mainly on the plain.";

expect(testString1.concat(testString2)).toBe("The rain in Spain lies mainly on the plain.");

