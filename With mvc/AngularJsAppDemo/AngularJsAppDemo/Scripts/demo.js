
/*global angular */

angular.module('uiAutocompleteDemo', ['ui.event', 'ui.autocomplete']).
controller('uiAutocompleteCtr', ['$scope', '$compile',
    function ($scope, $compile) {
        $scope.changeClass = function (options) {
            var widget = options.methods.widget();
            // remove default class, use bootstrap style
            widget.removeClass('ui-menu ui-corner-all ui-widget-content').addClass('dropdown-menu');
        };

        $scope.myOption = {
            options: {
                html: true,
                minLength: 1,
                onlySelectValid: true,
                outHeight: 50,
                source: function (request, response) {
                    var data = [
                            "Asp",
                            "BASIC",
                            "C",
                            "C++",
                            "Clojure",
                            "COBOL",
                            "ColdFusion",
                            "Erlang",
                            "Fortran",
                            "Groovy",
                            "Haskell",
                            "Java",
                            "JavaScript",
                            "Lisp",
                            "Perl",
                            "PHP",
                            "Python",
                            "Ruby",
                            "Scala",
                            "Scheme"
                    ];
                    data = $scope.myOption.methods.filter(data, request.term);

                    if (!data.length) {
                        data.push({
                            label: 'not found',
                            value: null
                        });
                    }
                    // add "Add Language" button to autocomplete menu bottom
                    data.push({
                        label: $compile('<a class="ui-menu-add" ng-click="add()">Add Language</a>')($scope),
                        value: null
                    });
                    response(data);
                }
            },
            events: {
                change: function (event, ui) {
                    console.log('change', event, ui);
                },
                select: function (event, ui) {
                    console.log('select', event, ui);
                }
            }
        };

    }
]).controller('MyController', function ($scope, $compile) {
    /* config object */
    $scope.myOption = function (listId) {
        return {
            options: {
                html: true,
                focusOpen: true,
                onlySelectValid: true,
                source: function (request, response) {
                    console.log(123, request, response)
                    var listData = $scope.data[listId];
                    var result = [];
                    angular.forEach(listData, function (s) {
                        result.push({ label: s, value: s });
                    });

                    response(result);
                }
            }
        };
    }
});



