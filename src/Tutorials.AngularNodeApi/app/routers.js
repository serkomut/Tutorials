var City = require('./models/city');

module.exports = function(app) {
    app.post('/api/createCity', function (req, res) {
        console.log(req.body);
        City.create({
            text: req.body.text
        }, function(err) {
            if (err)
                res.send(err);
        });
    });

    app.get('*', function(req, res) {
        res.sendFile('./public/index.html');
    });
};