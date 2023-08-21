app.controller("trips", function ($scope, $http, $window) {

    
        $http.get("https://localhost:44366/api/allsupplier").then(function (resp) {
            $scope.trips = resp.data;
        });
     
});