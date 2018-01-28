/*
 *	若竹
 *	2018/1/28
 *	jskny
*/


'use strict';


// HTMLファイルにURLで渡されたパラメーターを取得する。
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


// 配列のシャッフル
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


// デバッグ出力用
function DebugMsg(msg)
{
	console.log("[DEBUG] " + msg);
	return;
}


function DebugMsgObj(obj)
{
	console.log("[DEBUG OBJECT]");
	console.log(obj);
	return;
}


// 一度ボタンを押したらその後別のボタンを押しても意味無くする。
var g_flagSelect = 0;
var g_countSuccess = 0;
function ClickTrue()
{
	if (g_flagSelect) {
		return;
	}

	alert("CLICKED TRUE.");

	$("#app-q-ans").show();
	g_flagSelect = 1;
}


function ClickFalse()
{
	if (g_flagSelect) {
		return;
	}

	alert("CLICKED FALSE.");

	$("#app-q-ans").show();
	g_flagSelect = 1;
}


function Reset()
{
	g_countSuccess = 0;
	g_flagSelect = 0;

	g_index = 0;
}


// ステータスバー更新
function UpdateStatusBar()
{
	$("#app-q-score-text").text(
		g_db.length  + " 問中 " +
		g_countSuccess + " 問正解 [正答率 : " +
		Math.floor(g_countSuccess / g_db.length * 100) + "%]");
}


// 出題を行う
var g_index = 0; // 今なん問目か
function SetProblem()
{
	if (g_index >= g_db.length) {
		// すべての問題を処理した。
		SetFinish();
		return;
	}

	$("#app-problem-statement").text(g_db[g_index].statement);
	$("#app-problem-commentary").text(g_db[g_index].commentary);

	g_flagSelect = 0; // ボタンを再び押せるように。
	g_index++;
	$("#app-q-ans").hide();

	// ステータスバー更新
	UpdateStatusBar();
}


function SetFinish()
{
	// 全ての問題を処理した。
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

	DebugMsg("parameter id is " + params["id"]);

	// ボタンの関連付け
	$("#app-btn-q-true").click(ClickTrue);
	$("#app-btn-q-false").click(ClickFalse);
	$("#app-btn-q-retry").click(Reset);
	$("#app-btn-q-next").click(function () {
		// ページ・トップへスクロール
		var p = $("#app-card-main").offset().top;
		$('html,body').animate({ scrollTop: p }, 'fast');

		// 新しい問題をセットするか、すべての問題を処理していた時はクリア画面を表示する。
		SetProblem();
		return (0);
	});

	// データを取得する。
	// 必要ないけど一応、ディレクトリトラバーサル対策でピリオドを許容しない。
	var urlXML = params["id"];
	urlXML = urlXML.replace(/\./g , "ぽよ！");
	urlXML = "db/" + urlXML + ".xml";
	DebugMsg(urlXML);

	$.ajax({
		url: urlXML,
		async: true,
		cache: false,
		dataType: "xml",
		error: function(XMLHttpRequest, textStatus, errorThrown) {
			if (XMLHttpRequest.status == 200) {
				// それ成功。
				return;
			}


			$("#app-card-err-msg").html(
				"parameter : " + urlXML + "<br>" +
				"XMLHttpRequest : " + XMLHttpRequest.status + "<br>" +
				"textStatus : " + textStatus + "<br>" +
				"errorThrown : " + errorThrown.message);
			$("#app-card-err").show();
		},
		success : function(data) {
			DebugMsgObj(data);
			// タイトルをセット
			$("#app-subject").text($(data).find("subject").text());
			$("#app-subheading").text($(data).find("subheading").text());

			// 問題を取得
			$(data).find("problem").each(function(){
				var o = new Object();
				o.statement = $(this).find("statement").text();
				o.commentary = $(this).find("commentary").text();
				o.ans = $(this).find("ans").text();
				g_db.push(o);
				DebugMsgObj(o);
			});


			g_db = Shuffle(g_db);
			SetProblem();
			$("#app-card-main").show();
		},
		complete : function(data) {
			$("#app-card-loading").hide();
		}
	});
});

