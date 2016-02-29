'use strict';

var expect = require('expect');

var testString = "The rain in Spain lies mainly on the plain.";

expect(testString.substring(12, 17)).toBe('Spain');