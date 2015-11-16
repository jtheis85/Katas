function parseQueryString() {
    // Why use slice vs. substring? Slice returns a shallow copy

    // Remove the leading ? character
    var stripped = location.search.slice(1);
    // Get name/value pairs
    var pairs = stripped.split('&');
    return pairs.map(function(pair) {
        var parts = pair.split('=');
        return {
            name:  parts[0],
            value: parts[1]
        }
    });
}

var output = parseQueryString().map(function(param) {
    return 'Name: ' + param.name + ' Value: ' + param.value;
}).join('\n');

alert(output);
