var React = require('react');
var ReactDOM = require('react-dom');

var App = React.createFactory(React.createClass({
    displayName: 'app',
    render: function () {
        return React.DOM.div({}, 'Hello Gabby');
    }
}));

ReactDOM.render(App({}), document.getElementById('app-root'));