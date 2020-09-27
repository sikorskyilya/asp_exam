var ta;
var ws = null;
var bstart;
var bstop;

window.onload = function () {
    if (Modernizr.websockets) {
        WriteMessage('support', 'yes');
        ta = document.getElementById('ta');
        bstart = document.getElementById('bstart');
        bstop = document.getElementById('bstop');
        bstart.disabled = false;
        bstop.disabled = true;
    }
}

function WriteMessage(idspan, txt) {
    var span = document.getElementById(idspan);
    span.innerHTML = txt;
}

function exe_start() {
    if (ws === null) {
        ws = new WebSocket('ws://localhost:7000/Websokets.websocket');
        //ws = new WebSocket('ws://localhost:7000/Websokets.websocket');
        ws.onopen = function () { ws.send('Connection'); };
        ws.onclose = function (s) { console.log('onclose', s); };
        ws.onmessage = function (evt) { ta.innerHTML += '\n' + evt.data; };
        bstart.disabled = true;
        bstop.disabled = false;
    }
}

function exe_stop() {
    ws.close(3001, 'stopapplication');
    ws = null;
    bstart.disabled = false;
    bstop.disabled = true;
}