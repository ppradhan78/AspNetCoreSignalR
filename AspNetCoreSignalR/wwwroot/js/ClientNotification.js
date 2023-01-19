"use strict"

import { signalR } from "../lib/signalr/dist/browser/signalr"

var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();
connection.start();
connection.on("ReciveMsg", function (msg) {
    var li = document.createElement("li");
    li.textContent = msg;
    document.getElementById("msgList").appendChild(li);
});
