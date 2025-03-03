const timeSpan = document.getElementById('time');
const batteryContainer = document.getElementById('battery');
const innerRect = batteryContainer.querySelector('.inner');
const batteryText = document.getElementById('battery-text');

function updateTime() {
    let timeString = new Date().toLocaleTimeString();
    timeString = timeString.split(":");
    timeString = timeString[0] + ":" + timeString[1];
    timeSpan.innerHTML = timeString;
}

// Update time immediately
updateTime();

// Set interval to check every second, but only update when minute changes
let lastMinute = new Date().getMinutes();
setInterval(() => {
    const now = new Date();
    if (now.getMinutes() !== lastMinute) {
        updateTime();
        lastMinute = now.getMinutes();
    }
}, 1000);

const batteryLevel = parseInt(batteryContainer.dataset.level);
batteryText.innerHTML = batteryLevel;
innerRect.style.width = `${batteryLevel}%`;