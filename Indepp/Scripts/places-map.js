﻿var map;
var placesData;
var markersArray = [];
//var imagePath = '/content/images/';
var visitor_lat;
var visitor_lon;
var geocoder;
var ZoomLevel = 8;
var MapCanvas = 'placesMap';
var mapStyles = [{ "featureType": "administrative.land_parcel", "elementType": "all", "stylers": [{ "visibility": "off" }] }, { "featureType": "landscape.man_made", "elementType": "all", "stylers": [{ "visibility": "off" }] }, { "featureType": "poi", "elementType": "labels", "stylers": [{ "visibility": "off" }] }, { "featureType": "road", "elementType": "labels", "stylers": [{ "visibility": "simplified" }, { "lightness": 20 }] }, { "featureType": "road.highway", "elementType": "geometry", "stylers": [{ "hue": "#f49935" }] }, { "featureType": "road.highway", "elementType": "labels", "stylers": [{ "visibility": "simplified" }] }, { "featureType": "road.arterial", "elementType": "geometry", "stylers": [{ "hue": "#fad959" }] }, { "featureType": "road.arterial", "elementType": "labels", "stylers": [{ "visibility": "off" }] }, { "featureType": "road.local", "elementType": "geometry", "stylers": [{ "visibility": "simplified" }] }, { "featureType": "road.local", "elementType": "labels", "stylers": [{ "visibility": "simplified" }] }, { "featureType": "transit", "elementType": "all", "stylers": [{ "visibility": "off" }] }, { "featureType": "water", "elementType": "all", "stylers": [{ "hue": "#a1cdfc" }, { "saturation": 30 }, { "lightness": 49 }] }]

$(function () {
    drawMap(54.5, -3.5);
    GetPlaceLocations();
    geocoder = new google.maps.Geocoder();
    map.setZoom(4);

    $('#coffeeBox').click(function () {
        GetPlaceLocations();
    });

    $('#foodBox').click(function () {
        GetPlaceLocations();
    });

    $('#farmBox').click(function () {
        GetPlaceLocations();
    });

    $('#craftshopBox').click(function () {
        GetPlaceLocations();
    });
    
});

function GetPlaceLocations() {
    clearMapPoints();

    var inputs = {
        showCoffee: ($('#coffeeBox').is(':checked')) ? "Coffee": null,
        showFood: ($('#foodBox').is(':checked')) ? "Food" : null,
        showFarm: ($('#farmBox').is(':checked')) ? "Farms": null,
        showCraftShop: ($('#craftshopBox').is(':checked')) ? "CraftShops" : null
    };

    $.post("/Home/GetPlaceLocations", inputs, function (data) {
        placesData = data;
        DrawMapPoints();
        //$('#SpinnerDiv').html('');
    });
    //data is loading
    //$('#SpinnerDiv').html('<img src="/content/images/ajax-loader3.jpg"/>');
}