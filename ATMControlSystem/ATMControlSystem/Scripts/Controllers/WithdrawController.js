var WithdrawController = function ($scope, $routeParams, $location, WithdrawFactory) {
    
    $scope.withdrawForm = {
        accNum: '',
        amount: '',
        returnUrl: $routeParams.returnUrl,
    };

    $scope.withdraw = function () {
        
        var result = WithdrawFactory($scope.withdrawForm.accNum, $scope.withdrawForm.amount);
        result.then(function (result) {
            debugger;
            if (result.success) {
                if ($scope.withdrawForm.returnUrl !== undefined) {
                    $location.path('/Withdraw');
                } else {
                    
                    $location.path($scope.withdrawForm.returnUrl);
                }
            }
            else {
                
                $location.path("/withdraw/insufficientfund");
            }
        });
    }
}
WithdrawController.$inject = ['$scope', '$routeParams', '$location', 'WithdrawFactory'];
