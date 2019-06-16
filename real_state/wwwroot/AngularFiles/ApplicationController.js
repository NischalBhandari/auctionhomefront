(function () {
    'use strict';

    angular
        .module('Homeapp')
        .controller('ApplicationController', function ApplicationController($http, $scope) {
            
            $scope.GetEmployeeDetails = function () {
                //alert('d');
                var post = $http({
                    method: "GET",
                    url: "/Employee/GetEmployeeDetails",
                    responseType: 'json',
                    params: { searchText: $scope.searchText },
                    headers: { "Content-Type": "application/json; charset=utf-8" }
                }).then(function (d) {
                    $scope.loading = true;
                    $scope.student_data = d.data;
                    console.log(d);
                }, function (error) {
                    $scope.message = "Something went wrong";
                    $scope.loading = false;
                });
            };




            //write ur code above this
        });
})();



