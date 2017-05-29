const { skype } = require('skype-native');

window.skype = skype;

console.log(skype);

skype.on('incoming', (inviter, accept, reject) => {
    console.log(`Incoming call from ${inviter}`);
    window.accept = accept;
    window.reject = reject;
});

skype.on('connected', participants => {
    console.log(`Connected to ${participants}`);
});

skype.on('disconnected', () => {
    console.log('Disconnected');
});

skype.on('mute', state => {
    console.log(`Privacy mute changed to ${state}`);
});

skype.on('muted', () => {
    console.log(`Privacy mute on`);
});

skype.on('unmuted', () => {
    console.log(`Privacy mute off`);
});