app.controller('myCtrl', function ($scope, $http) {
    //$scope.firstName = "John";
    //$scope.lastName = "Doe";
    $scope.lookFor = "";
    //$scope.names = ["ulf", "Ali", "Ola", "Sven", "Adam"];
    $scope.names = [];

    $http.get("/Home/PeopleList")
        .then(function (response) {
            $scope.names = response.data;
        });

    $scope.addPerson = function () {
        $http.post("/Home/AddPerson", 
            { FirstName: $scope.firstName, LastName : $scope.lastName }
        ).then(function (response) {
            console.log(response);
            $scope.names.push(response.data);
        });
    }
});

app.controller('carCtrl', function ($scope, $http) {
    $scope.lookFor = "";
    // $scope.names = ["Saab", "Volvo", "Opel", "Skoda", "Audi", "BMW"];
    $scope.names = [];

    $http.get("/Home/CarList")
        .then(function (response) {
            $scope.names = response.data;
        });
});