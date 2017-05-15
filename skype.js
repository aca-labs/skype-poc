import path from 'path';
import edge from 'electron-edge';

export default {

    startCall: edge.func({
        source: path.join(__dirname, 'MeetNow.cs'),
        references: ['Microsoft.Lync.Model.dll']
    }),

    incoming: edge.func({
        source: path.join(__dirname, 'Incoming.cs'),
        references: ['Microsoft.Lync.Model.dll']
    })

};