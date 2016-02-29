var expect = require('expect');

var testString = "The rain in Spain lies mainly on the plain.";

expect(testString.indexOf('France')).toBe(-1);
expect(testString.indexOf('Spain')).toBe(12);