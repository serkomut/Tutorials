var express = require('express');
var app = express();
var morgan = require('morgan');
var mongoose = require('mongoose');
var database = require('./config/database');
var bodyParser = require('body-parser');

mongoose.connect(database.url);

var router = require('./app/routers');

var port = process.env.PORT || 3000;

app.use(express.static(__dirname + '/public'));
app.use(morgan('dev'));
app.use(bodyParser.json());

router(app);

app.listen(port);
console.log('Starting...');
console.log('Application listening port : ', port);
console.log('OTI PAIR TO PAIR CODING ACTIVITY...');