﻿var mongoose = require('mongoose');

module.exports = mongoose.model('City', {
    text : {type : String}
});