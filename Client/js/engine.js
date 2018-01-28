/*
 *	若竹
 *	2018/1/28
 *	jskny
*/


'use strict';


// http://ameblo.jp/linking/entry-10353146034.html
function GetUrlVars()
{
	var vars = [], hash;
	var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
	for(var i = 0; i < hashes.length; i++) {
			hash = hashes[i].split('=');
			vars.push(hash[0]);
			vars[hash[0]] = hash[1];
	}

	return vars; 
}


// http://h2ham.net/javascript-%E3%81%A7%E9%85%8D%E5%88%97%E3%81%AE%E3%82%B7%E3%83%A3%E3%83%83%E3%83%95%E3%83%AB
function Shuffle(array)
{
	var n = array.length, t, i;

	while (n) {
		i = Math.floor(Math.random() * n--);
		t = array[n];
		array[n] = array[i];
		array[i] = t;
	}

	return array;
}


// 問題リスト
var g_db = [];
// engine.html?id=読み込むDBのID
$(document).ready(function() {
	var params = GetUrlVars();
	if (!params["id"]) {
		// 読み込み DB が未定
		$("#app-card-err-msg").text("System don't find the parameter-id.");
		$("#app-card-err").show();
		$("#app-card-main").hide();
		return;
	}

	$("#app-card-main").show();
});

