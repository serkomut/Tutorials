var express = require('express');
var app = express();

var port = process.env.PORT || 8080;

app.use(express.static(__dirname + '/public'));
app.listen(port);
console.log('Starting...');
console.log('Application listening port : ', port);
console.log('OTI PAIR TO PAIR CODING ACTIVITY...');
