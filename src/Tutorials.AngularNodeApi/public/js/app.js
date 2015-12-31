angular.module('codingApp', [])
.controller('mainController', function($scope){
	$scope.title = 'OTI Coding Activity';
	$scope.cities = [];
	$scope.city = '';

	$scope.addCity = function(){
		$scope.cities.push($scope.city);
	};

	$scope.removeCity = function(index){
		$scope.cities.splice(index, 1);
	};
});
