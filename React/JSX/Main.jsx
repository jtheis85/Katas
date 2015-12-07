"use strict";

var React    = require('react');
var ReactDOM = require('react-dom');

var MainElement = React.createClass({
    displayName: "MainElement",
    render: function render() {
        return <div>Hello JSX!</div>
    }
});

ReactDOM.render(React.createElement(MainElement, null), document.getElementById("app-root"));
