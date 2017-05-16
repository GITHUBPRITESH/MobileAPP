(function () {
    'use strict';

    angular
        .module('app')
        .controller('APPcontroller', APPcontroller);

    APPcontroller.$inject = ['$location']; 

    function APPcontroller($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'APPcontroller';

        activate();

        function activate() { }
    }
})();
