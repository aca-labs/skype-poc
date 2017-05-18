const skype = require('skype-native');

window.skype = skype;

console.log('Attempting outgoing call');
skype.call('test@example.com');
