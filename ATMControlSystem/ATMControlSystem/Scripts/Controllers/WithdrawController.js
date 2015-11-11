var WithdrawController = function ($scope, $routeParams, $location, WithdrawFactory) {
    
    $scope.withdrawForm = {
        accNum: '',
        amount: '',
        returnUrl: $routeParams.returnUrl,
    };

    $scope.withdraw = function () {
        
        var result = WithdrawFactory($scope.withdrawForm.accNum, $scope.withdrawForm.amount);
        result.then(function(result) {
            if (result.success) {
                if ($scope.withdrawForm.returnUrl !== undefined) {
                    $location.path('/Withdrawal');
                } else {
                    $location.path($scope.withdrawForm.returnUrl);
                }
            } 
        });
    }
}
WithdrawController.$inject = ['$scope', '$routeParams', '$location', 'WithdrawFactory'];
