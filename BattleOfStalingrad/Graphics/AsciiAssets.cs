using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfStalingrad
{
    public static class AsciiAssets
    {
        private static string Nonna = @"
XNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNX
NWXKKKKKKXKKKXXXXXXXXXXXXXXXXXKKKKKKKKKKKKKKXXXXXXXXXXXXXXXXXKKKKKKKXXXXXXXNNNNWWWWWWWWMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNNNNNNNNNNNXXXXXXXXXXXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWWWWWWWWWWWWWWWNNNNNXXXXXXXXXXKKKKKKKKKKKKKKKKKKKKKKKKKKKKKXXXXXXXXXXXXXXXKKKKKKKKKKKKKKKKKKKKKKKXWN
NNOdddddddxxxxxxxxxxkkkkxxxxxxxdddddddddxxxxkkkkkOOkkkkkkkkkkkxxxxxxxkkkOOO00KXXNWWWWMMMMMMMMMMMMMMMMMMMWWWWWWMWWWWWWWWWWWWWWWWWWWWWNNNXXXXKKKKKKK000000OOOOOOOOOO000000KKKKKKKXXXXXNNNNNNNXXXXKKKKXXXNNNNNWWWWWWWWWNNNNXXKK00000OOkkkxxdddddddooooooooooooooddddxxkkOOO0000OOOkkkxxxxdddddddddddooooooookNN
NNkooooooodddddddddddddddddddddooooodddxxkkOOOO0000000000OOOOOkkxxxxxxxkkOO00KXNNWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWWWNNNXXXKKKKKKK000000OOOOOOOOO00000KKKKXXXXXNNNNNWWWWWWWWWNNNNNNNNNNWWWWWWWWWWWWWWWWWNNNXXXKKKK00OOkxxdddoooooooooooooooooooodddxxkkOOOO0OOOOkkkkkkxxxxxxxddddooooollllxNN
NNkoooooooooodddddddddddddddoooooodddxxkkO00KKKKKKKKKKKKKKKKK00OOkkkkkkkkO00KXXNWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMWWWWWWWWWWWWWWWWNNNXXXKKKKKKKKKK000000OO00000KKKKXXXXNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNXXXKK00OkxxddoooooooooooooooooooodddddxxkkOOOOOOOOOOOOOOOkkkkxxdddoooooooookNN
NNkoooodddooooooooddddddddoooooooddxxkkO00KKXXXXXXXXXXXXXXXXXKKK0OkkkkkkOO0KKXNNWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWNNNXXXXXKKKKKKKKKKKK000000KKKXXXXXNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNXXXKK00OkxxddooooooooooooooooooooodddxxxkkOOOO0000OOOOOOOOkkkxxddddooodoooONN
NNkooodddddddooooodddoooooooooodddxxkkOO0KKXXXXNNNNNNNNNNNNNXXXKK0OOOOOOO00KXXNWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWWWNNNNXXXXXXXXXXXXXKKKKKKKKKXXXXNNNNNWWWWWWWWWWWMMMMMMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNXXKK00OkkxddddooooooooooooooooooooddddxxkkOOOO00000000OOOOkkxxxdddddddddddONN
NNkoooodddddddooooooooooooooooodddxxkkO000KXXXXNNNNNNNNNNNNNNNXXXKK0000000KKXNNWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWWNNNNNNNNNNNNNNNXXXXXKXXXXXXXNNNNWWWWWWWWWMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWNNNXXK00OOOkxxddddooooddddddooooooddddddddxxxkkOOOOO00000OOOOkkkkxxdddddddxxxkk0NN
NNkoooooddddddoooooooooooooddooddddxxkkO000KXXXNNNNNWWWWWWWWWNNNNXXXXXKKKKXXNNWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWNNNNNNNNNXXXXXNNNNNNNNNWWWWWWWWWWMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWNNNNNNNNXXKK00OOkkxxddooooooodddddddddddddddddddxxxkkkkOOOOOOOOOOOkkkkkkxxxddddxxxkkOOKWN
NNkoooooodddddoooodddoooooodddddddddxxkkOO00KXXNNNWWWWWWWWWWWWWWWNNNNNNXXXXNNNWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNNNNNNNNNNNNWWWWWWWWWWWMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWNNNNXXXXXXXXXKKK00OOkkxxddooooooodddddddxxxxxxxxxxxxxxkkkkkkkkkkkkkkkkkkkkkkkxxxxxxxxkOO00XWN
NNkoooooodddddooodddddddooooodddddddddxxkkO00KXXNNNWWWWWWWWWWWWWWWWWWWNNNNNNNWWWWWWWWMMMMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNWWNWWWWWWWWWWWWWWWWWWWWWWMMMMMWWWWWWWWWWWWWWWNNNXXXXKKKXXKKKKKK00OOkkxxddooooodddddxxxxxxxxxxkkkkkkkkkkxxxxxxxkkkkkkkkkkkkkkkxxxxkkkO00KKNWN
NNkooooooodddooooodddddddooooooddddddddxxkkO0KKXXNNWWWWWWWWWWWWWWWWWWWWWWNNNNNWWWWWWWWWMMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNWWWWWWWWWWWWWWWWWWWWNNNNNXXXKK00OOOkkxxxddddddxxkkkOO0000KKKKXXNNNWWWNNNXXXKKKKKXXXKKKKK000OOOkxdddoddddddddxxxxxkkkkkkkkkkkkkxxxxxxxxxkkkkkkOOOOOOkkkkkkkkOO00KKXNWN
NNkoooooodddddoooooddddddddddddddddddddxxkkO00KXXNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMMMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNNNNNNNNWWWWWWWWWWWNNNXXK00Okxolcc:;,,''...................'',,,,,;::codxkOOO00KKKKKXXXXXXXXKKK00OOkkxddddddddddxxxxxkkkkkkkkkkkkkxxxxxxxxxxxkkkkOOOOOOOOOkkkkkOO00KKXXXNWN
NNkoooooooddddddoodddddddddddddddddddddxxxkOO0KKXXNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNWWWWWWWWWWWWWWNNNNNNNNNNNNWNNNNNNXK0Okxdlllc:,''...............................................',;:codxO0KXXXXXXXXKK0OkkkxddddddddxxxxxxxxxxkkkkkkkkkxxxxxxxxxxxxkkkOOOOOOOOOOkkkkOOO0KKKXXXNWN
NNkoooooddddddddddxxxxxxxxxxxxxdddddddxxxkkOO0KKXXNNNNNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNNNNNNNNNNNNNWNNNNNNNNNNNNNNNXXXK0Okxol:;,'..........  .....................................................',;cldxkO00KKK00OkkxxddddddddddxxxxxxxxxxkkkkxxxxxxxxxxxxkkkkOOOOOOOOOOOOkkOOO000KKKKKXWN
NNOoddddxxxxkkkkkkkOOOOOOOOOkkxxxxxxxxxxkkOO00KKXXXNNNNNNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNXXXXXXXXXNNNNNNNNNNNNNNNNNXXK0Oxdlc:,'.............  ....       ........   ............................................';:lodxkkkkkxxxdddddddddddxxxxxxxxxxxxxkxxxxxxxkkkkkOOO0000000OOOOOOOOOOO00000XWN
NNOdxxkkOOOO0000000KKKKKKK000OOOkkkkkkkkOO000KKXXXNNNNNNNNNNNNNNNWWWWWWWWWWWWWWWWWWNNNNNNNNNNNNNNXXXXXXXXXXXXXXXXNNNNNNNNXK0Oxdlc;'......  .....................    .............................................................';:clodxxxddddddddddddddddxxxxxxxxxxxxxxkkkkkOOO000000000OOOOOOOkkkkkkkk0NN
NN0kOO0KKKXXXXXXXXXXXXXXXXXXKKK000OOOOOO000KKKXXXXNNNNNXXXXXXXXNNNNNNNWWWWWWWWWWWNNNNNNNNNNNNNXXXXXKKKKKKKKKKXXXXXXXXKKOkoc;'......... ..........................    .    ..   .......................................................',;clooddddddoddddddddddxxxxxxxxxxxxkkkkOOOO00000000OOOOkkkxxxxxddxONN
NWK0KKXXNNNWWWWWWWWWWWWWWNNNNXXXXKKK000000KKKXXXXXXXXXXXXXXXXXXXXXXNNNNNWWWWWWNNNNNNNNNNNNXXXXXXKKKKK000KKKKKKKKK0Okdlc,......  ................            .....          ..   ...................         ...............................,;clodddddddddddddddddxxxxxxxxxxkkkkOOOOOOOOOOOOOOkkxxxdddddooONN
NWNXXNNWWWWWWWWWWWWWWWWWWWWWWWNNNXXXKKKKKKKKKXXXXXXXXXKKKKKKKKKKKXXXXNNNNNNNNNNNNNNNNNNNNXXXXKKKKKK00000000000Oxoc;'.... ... ..........                                          ................           ..................   .............',:cloddddddddddddddddddddddxxxkkkkkOOOOOOOOOkkkkxxdddoooookNN
NWNXNWWWWWWWMMMMMMWWWWWWWWWWWWWWNNNXXKKKKKKKKKKKKKKKKKKK000000KKKKKXXXXNNNNNNNNNNNNNNNXNNXXXKKKKK00000000Okxol:'..   ......   ..                                                     ...             ..    ..................... .... ...... .....';:looddddddoodddddddddddxxxxxxxxkkkkkkkkkkkxxdddooooookNN
NWNXNWWWWMMWMMMMMMMMWWWWWWWWWWWWWNNXXXKKKKKKKKKKKK00000000000000KKKKXXXXXXXNNNNNNNNNNXXXXXXKKKKK0000OOOkdl:,................                                                                              ...........  ...............................,;:looooooooooddddddddddxxxxxxxxxxxxkkkxxdddoooooookNN
NWXXXNNWWWWWWMMMWWWMMMMMMWWWWWWWWNNNXXXKKKKKK00000000000OO00000000KKKKKKXXXXXXXXNNNXXXXXXXXKKKK000OOkdl:'......  .....                                                                          ..  . ............     ......;cc;,................. .....';cloooooooooodddddddxxxxxxxxxxxxxxxxxddddooooookNN
NWX0KXXNNWWWWWWWWWWWWWMMWWWWWWWWWNNXXXKKK00000000000OOOOOOO00000000000KKKKKKKXXXXXXXXXXXXKKKK000OOxl;'..  .........                                                                                  ...,,,'.................;oxxdoc;,.................. ...,:loooooddddddxxxxxxxxxxxxxxxxxxddddddoooooookNN
NNKO00KXXNNNWWWWWWWWWWWWWWWWWWWNNNXXXKKK000000OO0OOOOOOOOOOOOOOOOO0000O000000KKKKKKKKKKKKKK000Okoc,... .. .......                                                                                     .';:llolcc:;,'..........,cdkkkkdl:;'................  ..,:loddxxxxxxxkkkkkkkkxxxxxxxxdddddoooooooookNN
NN0kkOO0KKXXNNNWWWWWWWWWWWWWNNNNXXXKKK000OOOOOOOOOOkkkkkkkOOOOkkOOOkkkkkkOOOO000000000000000Oxo:'..........',;,..                                                                                       ..,ldkkkkxddolc:;,'''..':lxOOOOkxdl:,'.............. ..';codxkkkkkkOOOOOOOkkkkkxxxxddddddooooooookNN
NNOxxkkOO0KKXXNNNNNNWWWNNNNNXXXXKKK0000OOOOkkkkkkkkxxxxxxxkkkkkkkkkxxxxxxxkkkOOOOkkkkkkkOOkdc,... .......,:cc,..                                                                                          ..;ldxkOOOOOkkkxdddollloxkOOOOOOkkxoc;'.............,clcccldkOO000000000OOOOkkxxxdddddoooooooookNN
NNOdxxxkOO00KXXXXNNNNNNNXXXXXKKKKK0000OOOOkkkkxxxxxxxxxxxxxxxxxxxxxddddddddxxxkkxxxxxxxxdl:'...........;loo:'.                                                                                              ..';ldkOOOOOOOOkkOOOkkOOOOOOOOOOOOkxoc;,..........,okxdc::lxO0KKKKKK000OOOkkkxxddddddooooooookNN
NNOdddxxkkOO0KKKXXXXXXXXKKKKKK000000000OOOkkkkxxxxxdddddddddddddddddddooooddddddddddddoc;............;ldoc,.                                                                                                   ..':okOOOkkxdodxkOOOOOOOOOOOOOOOOOkkxoc,.......':dkOkdc,,cdO0KKKKK000OOkkkxxxddddddoooooookNN
NNkoodddxxkkOO00000000000000000000000000OOOkkkkxxxxddddddddddddddddddddddddddddoooool:,...','.....':lddl;.                                                                                                        .,lxOOOkdc;',:codxkkOOOOOOOOOOOOOOOkxl:;:loolclxkOOxl;'':dOKKKK0000OOOkkkxxxxddddooooookNN
NNkoooooddxxxkkkkkkOOOOOOOO000000000000000OOOOkkkxxdddddddddxdddddddddddddddoooodol:,....;ll;...,coxdo:..                                                                                                          ..;lxkOkdc'....';cldxkkOOOOOOOOOOOOOkkxxkOOkkxkOOOOkxl,',lx0KK0000OOOOkkkxxxxxdddoooookNN
NNkoooooddddddxxxxxxxxkkkOOOOOO0000000000000OOOOkkxxxxddddddxxddddddddddddddoooolc,....'cddl,.':oxkdc'.                                                                                                              ..,cdxkxl,.......';:ldxkkOOOOOOOOOOOOOOOOOOOOOOOOOOkdc,',cdk00000OOOOkkkkxxxxxddddookNN
NNkoooooooooodddddddddxxxkkOOOOOOO00000000000OOOOkkxxxxxxddddxxxxdxxddxxxdddddoc;.....:okko:;coxxdc,.                                                                                                                   .';ldxo;.. ... ...';cldkkOOOOOOOOOOOOOOOOOOOOOOOOOko:'.':dO000OOOOOkkkkxxxxddddookNN
NNkooooooooooooooodddddxxxxkkkOOOOOOOOOOOOOOOOOOOkkkkxxxxddddxxxxxxxddxxxddddl:'....,cxOOxdodkkxl,.                                                                                                                       ..,:cc,.      ......,:oxkOOkxddxkOOOOOOOOOOOOOOOOOxl;'.,lxkOOOOOOOkkkkxxxdddoookNN
NNkoooooooooooooooooodddddxxxkkkkkkkkOOOOOkkOOkkkkkkxxxxxdddddddddxddddddddoc,.....:okOOkkkkkkd:'.                                                                                                                           .....         ......,:odxo:;;coxkOOOOOkkOOkxxkOOkxl;'';ldkOkkkOkkkxxxddoooookNN
NNkoooooooooooooooooddodddddxxxxxxxxxxkxxxxxkkxxxxxxxxxxddddddddddddddddddo:'.. .'cdkOOOOOOkxl,.                                                                                                                                             .......,::;...';coxkxdloddl::coxkOkxl;'':oxkkkkkkxxxdddoooookNN
NNkooooooooooooddoooooooooodddddddddddxddddddddddddddddddddooooooooooooool;.....,lxOOOOOOOko:..                                                                                                                                               ..   ...........',::;'.''....';codxxdl;,,:odxxxxxxdddooooookNN
NNkooooooooodddddddooooooodddddddddddddddddddddddddddddddddoooooooooooolc,....'cdkOOOOOOOkl,.                                                                                                                                                        ..........................',;cll:'.';lodddddooooooookNN
NNkooooooooodddddddddddddddddddddddddooooooddddoooooooooooooooooooooool:'....;lxOOOOOOOOxl'.                                        ..                                                                                                                .....   .....................',,....':looooooooooookNN
NNkoododoooodddddddddddddddddddddddddddooodddddooooooooooooooooooooool:'. ..;okOOOOOOOkxc..                                ...     .,lc'.                                                                                                                     ..............  ... ..........,coooooooooookNN
NNkooddddoooddddddddddddddddddddddooodddddddoodoooooooooooooooooooool:'....;okOkxkOOOkd:.                                 .,lc.    .l0Kkc'.                                                                                                                 ...............    ..  ........ .':looooolllokNN
NNkooooooooodddddddddddddddddddddddddddddddooooooooooooodooooooooool:'....;okOxolokOko;.                                 .,d0k;    .c0NNKx:.                                                                                                                ....    ............. .............;clooolllokNN
NNkooooooooodddddddddddddddddddddddddddddddooooooooooooooooooooooooc,....,lkOxl;;oxxl'.                                  'oKN0:.   .;ONWWN0o,.                                                                                                                      ........ ...  .... ...... ..,clooolllkNN
NNkooddoooooddddddddddddddddddoodddddooooooooooooooodddoooooooooooc,....;lkkdc,.,cl;..                                  .l0NNKl.    ,kXWWWWXkc.                                                                                                                ..    .......    .........  ... ..;looolllkNN
NNkoodddddooodddddddddddddddddoodddddooooooooooooooodddooooooooool;.. .,lxko;.......                                   .c0NWWXd'    'xXWWWWWNKd;.                                                                                                              .      ......         ........   ..:lollllkNN
NNkooddddddoddddddddddddddddddddddooooooooooooooooooodooooooooool:'. .'cdxl,.....                                     .:ONWWWNk;.   .l0WWWWWWWN0o;.                                                                                                                                  ......... . ..;cllllkNN
NNkooddodddddddddddddddddddddddddoooooooooooooooooooodooooooooooc,....:odl,....                                      .:kXWWWWN0c.   .;ONWWWWWWWNX0d;.                                                                                                                                  .......    ..;clllkNN
NNkoodooodddddddddddddddddddddddoooooooooooooooooooooooooooooool;.. .,ldl,.                                         .,xXWWWWWWXo.    'xXWWWWWWWWWWXOl'..                                                                                                             .                  ...... ... ..;clokNN
NNkooooooddddddddddddddoooddddddooooooooooooooooooooooooooooool:..  .,cc,.                                          'dXWWWWWWWNk;.   .lKWWWWWWWWWWWNXxo:.                                                                                                            .                 ..    ....   ..,clkNN
NNkoodddddddddddddddddddddddddddooooooooooooooooooooooooooooooc,..  .....                                          'dKWWWWWWWWNKl.   .:kNWWWWWWWWWWWWNXKd;.                                                                                                                            .      ...... ..':xNN
NNOddddddddddddddddddddddddddddddoooooooooooooddddoooooooooool:..  ....                                          .'oKWWWWWWWWWWNx,.  .'dXWWWWWWWWWWWWWWWN0x:.                                                                                                                          .      ...  ..  .'oXN
NNOdddddddddddddddddddddddddddddddddoooooooooddddddooooooooooc,..  .                                             'oKWWWWWWWWWWWN0c.   .lKNWWWWWWWWWWWWWWWWNKx:.                                                                                                                        .........  ..  . .cKN
NNkodddddddddddddddddddddddddddddddddddooooooddddddoooooooooo:'.  ..                                            .l0WWWWWWWWWWWWWXx,   .,xXWWWWWWWWWWWWWWWWWWN0d;.                                                                                                                      .........  .  ... :KN
NNkooddddddddddddddddddddddddddddddddddooooodddddddoooooooool;.....                                            .c0NWWWWWWWWWWWWWN0l.   .c0NWWWWWWWWWWWWWWWWWWWNKx:..                                                                                                         ..        ....      .   ....:KN
NNkoodddddddddddddddddddddddddddddddddddddddddddooooooodooooc'.. .                                            .cONWWWWWWWWWWWWWWWNO:.   'dXWWWWWWWWWWWWWWWWWWWWWNKxc,.                                                                                                       ..                 ...   .  :KN
NNOoododddddddddddddddddddddddddddddddddddddddddoooooooooool;..                                              .:ONWWWWWWWWWWWWWWWWWXx,.  .:ONWWWWWWWWWWWWWWWWWWWWWWNXOo;.                                                                                                           ..         .....      :KN
NNkoooodddddddddddddddddddddddddddddddddddddddddoooooooooool,.                                              .;kNWWWWWWWWWWWWWWWWWWNKo.   .oKWWWWWWWWWWWWWWWWWWWWWWWWWN0d;..                                                                                                            ..   .......      :KN
NNOoodddddddddddddddddddddddddddddddddooddddddddoooooooooooc,.                                             .,xXWWWWWWWWWWWWWWWWWWWWW0l.. .,xXWWWWWWWWWWWWWWWWWWWWWWWWWWX0xc'.                                                                                                          ............      :KN
NNOddddddddddddddddddddddddddddddddddddddddddddddoooooooooo:'.                                            .,xXWWWWWWWWWWWWWWWWWWWWWWN0o'. .;kNWWWWWWWWWWWWWWWWWWWWWWWWWWWNXOo;..                                                                                                          ........       :KN
NNOdddddddddddddddddddddddddddddddddddddddddddddooooooooooo:..                                           .'dXWWWWWWWWWWWWWWWWWWWWWWWWWKd,. .cONWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKko:'.                                                                                                 ..    .......        :KN
NNOdddddddddddddddddddddddddddddddddddddddddddddoodddoooool;..                                           'oKNWWWWWWWWWWWWWWWWWWWWWWWWWWXx;. .l0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNKOo;..                                                                                                       .       .   :KN
NNOdddddddddddddddddddddddddddddddddddddddddddddooodddooool;..                                          .l0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWXk;...l0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKko;..                                                                                                            .   :KN
NNOdddddddddddddddddddddddddddddddddddddddddddddoooooooodol,.                                          .l0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXOl'..l0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKko:'.                                                                                                 ....    .   :KN
NNOdddddddddddddddddddddddddddddddddddddddddddddooodddooooc,.                                         .c0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKx;..l0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNX0d,.                                                                                                 ...    .   :KN
NNOdddddddddddddddddddddddddddddddddddddddddddddoooddoooooc'.                                        .c0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXOc..cOXWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNXK00000Oxlccc:,..                                                                                                  .   :KN
NNOddddddddddddddddddddddddddddddddddddddddddddooooooooodo:'.                                      .'l0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKd;':xXWWWWWWWWWWWWWWWWWWWWWNNXKOkkxdddxk0KKKKXXNX0koc,...                                                                                             .   :KN
NNOdddddddddddddddddddddddddddddddddddddddddddddoooooooddo:..                                     .,dKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXkc,;dKNNWWWWWWWWWWWWWNXK0kdolllodkOKXNNWWWWWWWWWWWNX0kdl;'..                                                                                         .   :KN
NNOdddddddddddddddddddddddddddddddddddddddddddddoooooooddo;.                                     .,dKWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKx::ox0NWWWWWWWWNX0kdl:::coxOKXNNWWWWWWWWWWWWWWWWWWWWNXKOxl:,...                                                                             ........   :KN
NNOdddddddddddddddddddddddddddddddddddddddddddddddddddoddl;.                                    .,dXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0dlloOXWWWWNKOdl:;:ldk0KXNWNNXXXNNWWWWWWWWWWWWWWWWWWWWWNNK0kdl;..                                                                           .......   :KN
NNOddddddddddddddddddddddddddddddddddddddddddddddddddddddl;.                                   .;xXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKOkxk0K0ko:;:cdk0XXXXKK000000KXNWWWWWWWWWWWWWNNNNNNXXXXKK0Oxl,.                                                                            ..       :KN
NNOddddddddddddddddddddddddddddddddddddddddddddddddddddddl;.                                  .:kXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0x:;;;:ox0XXXKOkxxkkO0KXXNNWWWWWWWWNNXK0Okxdolcc:::;;,,'...                                                                                      :KN
NNOddddddddddddddddddddddddddddddddddddddddddddddddddddddl;.                                 .cONWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXOoc:oOXXX0kdlcokKXNNWWWWWWWNNXXKOkdl:;'......                      .....                                                                  ..    :KN
NNOddddddddddddddddddddddddddddddddddddddddddddddddddddddo;.                                .l0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNXXKK0Okxdoodk0NWWWWWWWNXKOxoc:,...                  ..,'.       .,lxkxo:'.                                                                ..   :KN
NNOddddddddddddddddddddddddddddddddddddddddddddddddddddddo:.                              .'oKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWX0Okkkxx0XNWWWNXK0koc;...   .....         ...    .ckd,     .;d0XNWNNXOc.                                                                .   :KN
NNOddddddddddddddddddddddddddddddddddddddddddddddddddddddo:.                             .;xXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXXKKKKXNWNXKOdl;'..    ..':oxkko'.    .......   .oKO:.  .'lOXWWWWWWWXx,                                                                   .:KN
NNOddddddddddddddddddddddddddddddddddddddddddddddddddddddoc'.                           .cOXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNXXXNNWNNX0xc'..     .':okKXWWWNk;...'.........  'xN0:. .;xKNWWWWWWWWXx,                                                                   .:KN
NNOddddddddddddddddddddddddddddddddddddddddddddddddddddddoc,.                         .,dKNWWWWWWWWWWWWWWWNNNNNNNNNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNWWWX00Oxc.   ..,;cx0XNNNXKOd:..'lko'. ...'...,ONk,.'l0NWWWWWWWWWWXx,                                                                   .:KN
NNOdddddddddddddddddddddddddddddddddddddddddddddddddddddddl,.                        .:kXWWWWWWWWNNNXXKOkxxdddoooooddxkO0KXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNXKkl,..':dOKOdcclolc;,'....,okd,. .,lc'..c0Xx;:xKWWWWWWWWWWWWXx,                                                                    :KN
NNOdddddddddxxxdddddddddddddddddddddddddddddddddddddddddddl;.                      .'o0NWNNNNXXKK0OOkxdolccccccccccccllodk0XWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXOocldk0XNWWNk;. .....',;,'..'.. .'oOx;.,xXXOOKNWWWWWWWWWWWWWNx,                                                                    :KN
NNOdddddddxxxxxxdddxxxddddddddddddddddddddddddddddddddddddo:.                     .,dKNNXKKK0K0KKKKKKKKKKKKKXXXK00OkkxdodxOKXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXKKKXNWWWWWMWNk;. ..,:::::,'... .'lOOo''lKWNNNWWWWWWWWWWWWWWWXx,                                                                    ;KN
NNOddddddddxxxxdddddddddddddddddddddddddddddddddddddddddddoc'.                    .l0XXXKXXXNNNWWWWWWWWWWWWWWWNXKK000OxolooxOKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMWNd'...,;::::;;,'..';ldl;'c0WWWWWWWWWWWWWWWWWWWWXd'                                                                    ;KN
NNOddddddddxxxxddddddddddddddddddddddddddddddddddddddddddddc,.                    .:OXNNNWWWWWWWWWWWWWWWWWWWWWWWNNNNNNXXK0kkk0XNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXd,...';:::::::ccclooddxKNWWWWWWWWWWWWWWWWWWWWKd'                                                                    ;KN
NNOddddddddxxxxddddddddddddddddddddddddddddddddddddddddddddl;.                     .l0WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXXXXNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXOxdodxkOOOO000KKXXXNNWWWWWWWWWWWWWWWWWWWWWWWKo'                                                                    ;KN
NNOddddxxddxxxxddddddddddddddddddddddddddddddddddddddddddddo:'.                     'dXWWWWWWWWWWWWWWWWWWWWWWWWNNNNXXXKK0OOkkkkkOKXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWKo.                                                                    ;KN
NNOddddddddxxxxdddddddddddddddddddddddddddddddddddddddddddddl,.                     .,xXWWWWWWWWWWWWWWWWWWNXK0Oxdolc:;,,''......':dKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWKl.                                                                    ;KN
NNOdddddddddxxxdddddxdddddddddddddddddddddddddddddddddddddddo:.                      .;kNWWWWWWWWWWWWNNKOkoc;'......           ..,lOXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0c.                                                                    ;KN
NNOddddddddddxdddddxxxxddddddddddddddddddddddddddddddddddddddl,.                      .:ONWWWWWWWNXKOdc;'..  ..,cooc.  ....   .;dkO0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNO;.                                                                    ;KN
NNOddddddddddddddddxxxxxxxxxddddxddddddddddddddddddddddddddddo:..                      .:OXWWWNX0xl;..   ..':oOXNWNO:.......  .c0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXd'        .........                                                    ;KN
NNOdddddddddddddddxxxxxxxxxxxddxxddddddddddddddddddddddddddddoc,.                       .;d0K0xc,.    .':oxOXNWWWNKd::odc...  .:ONWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0c.     .'cdkOOOkkxo:'.                                                 ;KN
NNOddddddddddxxddddxxxxxxxxxddddddddddddddddddddddddddddddddddo:'.                       ..;;'..     .:kXNWWNKOxdo:'':xOl'.....'dXMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNx,     .;xXNWWWWWWNNXOo;.                                               ;KN
NNOdddxxxddxxxxxdddxxxxxxxxddddddddddddddddddddddddddddddddddddl,.                         ..,'..    .oKWWWWNO:.......''..,ll;..lXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWKl.    .;kXWWWWWWWWWWWWN0o,.                                             ;KN
NNOddxxxddxxxxxxxxxxxxxxxxxdddddddddddddddddddddddddddddddddddoc'.                         .;xOkoc,...;xXWWMWXd' ..',''..,oOOo,;xXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXx,.   .,xXWWWNNXK0KXNWWWNXx;.                                            ;KN
NNOdxxxxdxxxxxxxxxxxxxxxxxxxxxddddddddddddddddddddddddddddddddo:.                           .lOXNXKOo:;ckXWMWWXo...,:::;;:ldkkxOXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0c.   .'dXWWXK00OO00XNWWWWWXd,.                                           ;KN
NNOdxxxxxxxxxxxxxxxxxxxxxxxxxdddddddddddddddddddddddddddddddddo;.                            .cONWWWNX0OOKXWWWWKl...',;;:cdkKXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXk;.  .'oKNNKOk0KNNNNWWWWWWWWKl.                                           ;KN
NNOdxxxxxxxxxxxxxxxxxxxxxxxxxxddddddddddddxxxdddddddddddddddddl,. ..                          .l0NWWWWWWNNNWWWWW0l,',:lxOKXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWKo.   .l0NX0kOKNWWWWWWWWWWWWWNk;.                                          ;KN
NNOdxxxxxxxxxxxxxxxxxxxxdxxxxxxxxxxxxxxxxxxxxxxxxxxxddddddddddc'..,,.                      ....;dKWWWWWWWWWWWWWWNX0O0KXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0:.  .c0XX0OKNWWWWWWWWWWWWWWWW0l.                                          ;KN
NNOdxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxdddxxxxxxxxxxdddddxdc,';ll;.              ...',:lodxxddONWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXx,  .:ONX00XNWWWWWWWWWWWWWWWWWXd'                                          ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddddddxxxxxxxxxxxxxxdc;:lddc'.          ..,cdk0KXNNWWNXOkKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNK0KNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0l. .:ONXKKNWWWWWWWWWWWNNNWWWWWXd'                                          ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddddddxxxxxxxxxxxxxxdolldxxo:'.     ..';lx0XNWWWWWWWWWWKkOKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKOOXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNk,..;kXXKXNWWWWWWWWWWWXKKNWWWWN0l.                                          ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxdddddxxo:'.  .;lx0KNWWWWWWWWWWWWWWN0xOXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXo..,xXNKKXWWWWWWWWWWWN0OKNWWWWNx,.                                          ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddxxxddxxxxd:'.:xKWWMMMMWWWWWWWWWWWWWWXOkKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0l.,dXWNKO0NWWWWWWWWWNX00NWWWWN0c.                                           ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxdxxxdoccdKWMMMMMMMMMWWWWWWWWWWWWNXOOXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKo;oKWWWNK0KNWWWWWWWNX0KXNWWWWKo.                                            ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxdold0NMMMMMMMMMMMWNNNWWWWWWWWWN0kOXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXkdONWWWWNXKNWWWWWWNX00XWWWWNKo'                                             ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxdoox0NWMMMMMMMMMWWWWNKO0XWWWWWWWWXkx0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXK0XWWWWNKO0NWWWWWNX00XWWWWN0l.                                              ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxookXWMMMMMMMMMWWWWWWXOddkKNWWWWWWN0xxKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXXNWNX0OkOXWWWWWNX00XWWWWXk:.                                               ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddx0NWMMMMMMMMWWWWWWNXKKK0OOKNWWWWWWXxokXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNX0kkOKNWWWWNXKKXNWWWN0o,.                                                ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddkKWMMMMMMMMMWWWWWWWWNXNWWNXKXWWWWWWXkcl0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKkxOXNWWWNXKKKXNWWWN0d;.                                                  ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddkXWMMMMMMMMMWWWWWWWWWWWWWWWXXXWWWWWWXx,,dKWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXkooOKXKK0000XNWWWN0d;.                                                    ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddkXWMMMMMMMMMMWWWWWWWWWWWWWWNK0XWWWWWNKo;,lONWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKOkkOOOO0KXNNWWN0d;.                                                      ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddxKWMMMMMMMMMMMWWWWWWWWWWWWWWN0kKNWWWWNOodxxx0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNNNWWWNKkl,.                                                        ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddxKWMMMMMMMMMMMWWWWWWWWWWWWWWWN0kKNWWWNKxoOX0xkXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXKKNWWWNX0OO0KNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKx:..                                                          ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxod0WMMMMMMMMMMMMWWWWWWWWWWWWWWWN0k0NWWWNkldKWN0xOXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXXNWWWWWNNXXXXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNWWWWWWWWWWN0d:.                                                             ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddONMMMMMMMMMMMMMWWWWWWWWWWWWWWWWKO0NWWWXd:dKWWXOx0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXK00KXNWWNXKkl,.                                                               ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxddkXWMMMMMMMMMMMMMWWWWWWWWWWWWWWWWN00XWWWKo;l0NWWXkx0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXKKKKOdlodkxl;..                                                                 ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkkxdkKWMMMMMMMMMMMMMWWWWWNXXNWWWWWWWWWX00XNNKxllkXWWWKxd0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXXNWN0c......                                                                    ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkxdxKWMMMMMMMMMMMMMMWWWWWXKKNWWWWWWWWWNXK0000KOolkXWWXkcckXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKd'                                                                          ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkkxxxxxxxddONMMMMMMMMMMMMMMWWWWWNK0XNWWWWWWWWWWWNXXXNXk;.,oxkxc..,o0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWKo'                                                                           ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkkxkxxxxddkXWMMMMMMMMMMMMMMWWWWWNKKXWWWWWWWWWWWWWWWWNKo. ......   .;xKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKo.                                                                           ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkkkxxkxdoxKWMMMMMMMMMMMMMMMWWWWWNKKNWWWWWWWWWWWWWWWWW0l.           .'ckKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXx,.                                                                          ;KN
NNOxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkkxkkxdxKWMMMMMMMMMMMMMMMMWWWWWXKXNWWWWWWWWWWWWWWWWWKo.             .'lkKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXXXNWWWWWWWWWWWWWNOc.                                                                          ;KN
NN0xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkxxxkkxdxKWMMMMMMMMMMMMMMMMWWWWWWXKXWWWWWWWWWWWWWWWWWWNx,.          ..':odxk0XWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNK0O0XNWWWWWWWWWWWWWWXd.                                                                          ;KN
NN0xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkkkkkxxkkxdxKWMMMMMMMMMMMMMMMMMWWWWWNKKXWWWWWWWWWWWWWWWWWWW0l.        .'cdOKXX0kxkOKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXK0OOKNWWWWWWWWWWWWWWWWXd.                                                                          ;KN
NN0xxxkkkkkkkkkkkkkkkkkkkkxxxxxxxxkkkkkkkkkkkkkkkxodONMMMMMMMMMMMMMMMMMMWWWWWNK0XWWWWWWWWWWWWWWWWWWWNOc.    ..:oOXNWWWWWNX0kkO0KXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNX0OO0XNWWWWWWWWWWWWWWWWWNKo.                                                                          ;KN
NN0xxkkkkkkkkkkkkkkkkkkkkkxxxxxxxxxkkkkkkkkxxkkkxddONWMMMMMMMMMMMMMMMMMMWWWWWN00XWWWWWWWWWWWWWWWWWWWWNOc....:xKNWWWWWWWWWWWNX0xllx0XNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNX0OkO0XNWWWWWWWWWWWWWWWWWWWNKl.                                                                          ;KN
NN0xxkkkkkkkkkkkkkkkkkkkkkkxxxxxxxkkkkkkkkkxxkkxddONWMMMMMMWWMMMMMMMMMMMWWWWWX00NWWWWWWWWWWWWWWNNXXXXXKx::lkKNWWWWWWWWWWWWWWN0d,..':ox0XNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXKOkkO0XNWWWWWWWWWWWWWWWWWWWWWN0c.                                                                          ;KN
NN0xxkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkxdd0NWMMMMMMMWWWMMMMMMMMMMWWWWWX00NWWWWWWWWWWWNXK00000OOOOO0XWWWWWWWWWWWWWNNKOo;..    ..';okKNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNX0kkk0KXXNWWWWWWWWWWWWWWWWWWWWWWN0c.                                                                          ;KN
NN0xxkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkxddONWMMMMMMMWWWWMMMMMMMMMMWWWWWX00NWWWWWWWWWWXK00KXNNNNNNNNWWWWWWWWWWWWWNKkl;'.           ..;lxOKNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKOkxkOKKXNNWWWWWWWWWWWWWWWWWWWWWWWWNO:.                                                                          ;KN
NN0xxkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkxdx0NWMMMMMMMWWWWMMMMMMMMMMMWWWWWX0KNWWWWWWWWWWNNNWWWWWWWWWWWWWWWWWWWWWWN0d;..                  .';lxOXNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNKOkxxk0KXXNNWWWWWWWWWWWWWWWWWWWWWWWWWWNO:.                                                                          ;KN
NN0xxxkxxxxkkkkkkkkkkkkkkkkkkkkkkkkkxxkkkkkxdx0NMMMMMMMWWWWWWMMMMMMMMMMWWWWWWX0KNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0d;.                         .':okKXXNWWWWWWWWWWWWWWWWWWWWWWWNX0kxdxkOKXXXNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0c.                                                                          ;KN
NN0xxxkxxxkkkkkkkkkkkkkkxxxkkkkkkxxkkkkkkkxod0WMMMMMMMMWWWWWWMMMMMMMMMWWWWWWNXKXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0d;.                              ..,:cdOKXNWWWWWWWWWWWWWWWNXKOxdodkOKKXXXNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0c.                                                                          ;KN
NN0xxxkxxxkkkkkkkkkkkkkkxxxkkkkkkxxxkkkkkxod0WMMMMMMMMWWWWWWWMMMMMMMMMWWWWWWXKKXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXk:.                                     ..;cdOKXNWWWWWWNNXK0xllloxOKXXXXXNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKl.                                                                          ;KN
NN0xxxkxxkkkkkkkkxxkkkkkxxxkkkkxxxddoodddooONMMMMMMMWWWWWWWWWMMMMMMMMWWWWWWWXO0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXx;.                                          ..,coxk00Okxol;'.,ok0KXXXXXNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKo.                                                                          ;KN
NN0xxxkxkkkkkkkkkkkkkkkkkkkkxdollc::;;;;,;dXWMMMMMMMWWWWWWWWWWMMMMMMMWWWWWWNKOKNWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKd,.                                                ........   .;xKXXXNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXd.                                                                          ;KN
NN0xkkkkkkkkkkkkkxkkkkkkkxdoc:;;;::cccc;,:OWMMMMMMWWWWWWWWWWWWMMMMMMWWWWWWWK00XWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0o'                                                              'dKNNWWWWWWWWWWWWWWWWWWWWWNNNNNNNXXXXXXXXXXXXXK0o'                                                                          ;KN
NN0kkkkkkkkkkkkkxxkxxkkxdl:,,;:cccloooolcxXWMMMMMWWWWWWWWWWWWWMMMMMMWWWWWWX00XWWWWWWWWWWWWWWWWWWWWWWWWWWWNKk:.                                                               .dXWWWWWWWWWNNNNXXKKK0OOkxxdddoolllllcccccccccc:,..                                                                         ;KN
NN0kkkkkkkkkkkkkkkkxxxxo:,,;cllc;;cooolco0WMMMMMWWWWWWWWWWWWWWMMMMMWWWWWWNKKXWWWWWWWWWWWWWWWWWWWWWWWWWWNKkc'.                                                                .oKNNNXXK0Okxdoolcc:;;,,,''''''..............................                                                               ;KN
NN0kkkkkkkkkkkkkkkkkxdc;,;cloooc,';looclkXMMMMMWWWWWWWWWWWWWWWMMMMWWWWWWNXKXNWWWWWWWWWWWWWWWWWWWWWWWWNKkc'. ..                                                               .;dOkdlc:;,'''..................................................                                                            ;KN
NN0kkkkkkkkkkkkkkkkxo:;;cloooool:,,:ooldKWMMMMMWWWWWWWWWWWWWWWWMWWWWWWWWWNNWWWWWWWWWWWWWWWWWWWWWWWNXOd:'.     .                                                              ..',,'............................................................                                                          ;KN
NN0kkkkkkkkkkkkkkkdl:,:looooooool;',:loONMMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXOdc'.                                                                     .....................................................................                                                         ;KN
NN0kkkkkkkkkkkkkkdc;,;cooooooooooc,',ckNWMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKko:,..                                                                    .........................................................................                                                        ;KN
NN0kkkkkkkkkkkkkdc;,:looooooooooooc,,oKWMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKOxc'..              ....                                               .   ...........................................................................                                                        ;KN
NN0kkkkkkkkkkkkxc;,:looooooooooooolccdKWMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXKOxdolc,.              ..;,..                                       ......................................................................................                                                        ;KN
NN0kkkkkkkkkkkxl;;:looooooooooooooolclkXWMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXKOxdoddxxxo:..             .,cc,...                                  ........................................................................................                                                        ;KN
NN0kkkkkkkkkkdl;;coooooooooooooooooolccdKWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNKOxdoddxkkkkkxdl,..            .,loc;..                                ....................',,,'................................................................                                                        ;KN
NN0kkkkkkkkkxl;,:oooooooooooooooooooolccoOXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXOxdddxxkkkkkkkkkkxo;..            .,ldoc,..                               ..................;ldxdc'...............................................................                                                        ;KN
NN0kkkkkkkkdl;;:loooooooooooooooooooooolclx0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXOdoodkkkkkkkkkkkkkkxxo:'.            .,ldxoc;..                               ...............,lkOOkl'...............................................................                                                        ;KN
NN0kkkkkkkxl;,:loooooooooolllllllllllllllc:lxKNWWWWWWWWWWWWWWWWWWWWWWWWWWWNKxloxkkkkkkkkkkkkkkkkkkkdl,.            .,ldxxdl:'..                              .............':oxdl,...............................................................                                                         ;KN
NN0kkkkkkkd:,:looooooooll:;;;,,,,,,,,,;,;;,',cxKNWWWWWWWWWWWWWWWWWWWWWWWWN0dloxkkkkkkkkkkkkkkkkkkkkkxo;..           .,ldxxxxoc;'..                             .............',,..............................................................         ..........                                         ;KN
NN0kkkkkkdc;;cooooooooc:;''...............'...,o0XWWWWWWWWWWWWWWWWWWWWWWN0o:lxkkkkkkkkkkkkkkkkkkkkkkkxdc,.           .'cdxxxxxdoc;...                            ........................................................................        ..    ....'''''.....                                    ;KN
NN0kkkkkdc;;cooooooolc;'.......................':x0NWWWWWWWWWWWWWWWWWWWN0o;';okkkkkkkkkkkkkkkkkkkkkkkkxxo:'.          .'cdkxxxxxxdl:;'..                           .. ...............................................................     ....     ..    ...'',,,,''.......                              ;KN
NN0kkkkxl;;cooooooolc;'..........................'ckXWWWWWWWWWWWWWWWWWNKd:;;,;oxkkkkkkkkkkkkkkkkkkkkkkkkxdl,..         .'cdxxxxxxxxxdol:,..                            .............................................................     .....    ............'',,,,,,,'''..........                     ;KN
NNKkkkxl;,:ooooooooc;'.............................;oOXWWWWWWWWWWWWWWNKd;,,;,,:oxkkkkkkkkkkkkkkkkkkkkkkkkkxoc,..        ..:oxxkxxxxxxxxxol:'..                          .........................................................     .......    ..   .... .......''',,,,,,,,,,,,'''.........            ;KN
NN0kkkd:,;loooooool:,'...........................'..';d0XWWWWWWWWWWWNKd;'.',,',:oxkkkkkkkkkkkkkkkkkkkkkkkkkkxoc,.         .:oxkxxxkkkxxxxxxoc'.                          .....................................................      ..........     .....    ..........''',,,,,,,,,,,,,,,,''''.....       ;KN
NN0kkxl;;cooooooolc;'.................................';o0NWWWWWWWWNKd;....',,'':dkkkkkkkkkkkkkkkkkkkkkkkkkkkxxoc,.        .:oxkkxxxkkxxxdoc;'...                         ..................................................      ...   .....      .....    ..    ........'',,,,,,,,,,,,,,,,,''''....    ;KN
NN0kxo:,:looooooolc,'...................................':xKNWWWWWNKd,......',,,;ldkkkkkkkkkkkkkkkkkkkkkkkkkkkkkxo:'.       .;oxkkkkxxdoc;,.......                          ..............................................   ...   .   .....   ..  ...........   .............'',,,,,,,,,,''...........  ;KN
NN0kdc,;cloooooool:,......................................,lOXWWWWXx;........',,,:oxkkkkkkkkkkkkkkkkkkkkkkkkkkxkkkdl;..      .,ldxxol:;,'........     .....                     ........................................    ....... .............................................',,,,,,,'...............:KN
NN0xl;,:loooloool:,'........................................,lOXWXO:..........''',lxkkkkkkkkkkkkkkkkkkkkkkkkkkkxkkkxdc,.      .';;;,'............   ...........                 .....................................      ...     .................................   ............',,,'......',,,'''....:KN
NN0o:,;cooooooool;'...........................................;okxc'..............;okkkkkkkkkkkOOkkkkkkkkkkkkkkkkkkkkxdc,.       ...''........... ...............                 .................................   ............   ......................................... ......'.......',:llc:,'...cXN
NNOc,;clooooooolc,'...............................................................,lxkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkxxxo:..       ...... ....   ..................                 ..............................   ............ .............................................................,;::;,'',;;dXN
NNx;,:looooooool:,'...............................................................'cxkkkkkkkkkkkkkkkkkkkkkkkkkkkxddocc:;,'..        ...  ...   ................... ...              ...........................    ................'... ....     ................ ......... ......  ................,;cllkNN
NXo,;coooooooooc;'.................................................................:dkkkkkkkkkkkkkkkkkkkkkkxxdol:;,''''''''..         .....   ....................  ... .             .......................  ........  .............  ..................    ...................  .................',;::xXN
NXl;cloooooooolc,'.................................................................;oxkkkkkkkkkkkkkkkkkxdol:;,'''''''''''....           ...  .................      ..........         ....................    ..   ..   .....        ........   ........  ...............  ....  .....................''lXN
NXl:loooooooool:,'.................................................................,lxkkkkkkkkkkkkkkkdl:;'...''',,''...........             ....................   ..............        ...............                               .....      ....... ......  ............  .........................cXN
NXdcooooooooooc;'..................................................................,lxkkkkkkkxxxdool:,'..'',,,''..............             .........................................      ............                                                     .....  ...........  ..........................cXN
NXxlloooooooooc,'..................................................................,oxkkxxdoc::;,'......''''.....................          ............................................    ..........                                                            ..........   ...........................cXN
NNkllooooooool:,...................................................................;looc:;;,,',,;,'...................... ......   .        ..............................................  ........    ...                                                            ...  .............................cXN
NNkooooooooool:,....................................................................,,,,,,;,'',::;'......................  .....  ....       ......................................................  .......  ...........       .......                                   ...............................cXN
NNkoloooooollc;'....................................................................',;:cc;'..',,..  ..........................   ...         ...............................................      ....................         .........  ...  ..                       ................................cXN
NNkllloooooolc,'..................................................................';ccccc;'.......   ..................... ....   .       ...................................................      ..................     ...  ....   .............   .....             .................................cXN
NNklloooooool:,..................................................................';cc:;,'......... .. .....................               ..................................................    ...  .......       .   ......  ....   ..........      .........   ..  ...................................cXN
NNxcclooooool:,.................................................................';:;,''..........  .........     .....                    ................................................    ...   ..            ...........  .................     .... ........   ....................................cXN
NXd;,:loooool:,.................................................................',,.............. ...........                        .   ...............................................    .........        ................       .............................    ....................................cXN
NNx;',clooool:,.................................................................................. ... ......                     .. ...  .............................................     ...........      .....................      .......................      .....................................cXN
NNx:'';looool:,................................................................................. ....                            ...... ...........................................     ...............           ................      ......................      .....................................cXN
NNkc;',:loool:'................................................................................. ...                      ...... .....   ........................................     ..................          .............        .........................    .....................................cXN
NNklc,';loool:,........................................................................ .......                      .. ..............   .......................................    ..........  ........  .   .  .........   ..       ...........................   .....................................cXN
NNkol:'':lool:,'......................................................................   ......                 ... ..................   ...................................    ..    .......  ......... ......   ......   ..........  ......................  ..   .....................................cXN
NNxc:;'.,clol:,........................................................................  .....               .......................... ..................................   ...............   .   .......   ..   ....     ....  ....  ...........................  .....................................cXN
NXo,''...,cll:,........................................................................  ....              .....................  .  .  ...............................    .................. ...  ......    ..            ....  ....  ...........................  .....................................cXN
NXl.......;cl:,......................................................................... ....       .........................     .  .  .............................    ...................   .........     ..           ..     ....   ......    ............ ..  ......................................cXN
NXc.......';c:,'............................................................................   ... ..........................    ..      ...........................  ......................             .     .               .....    ......     .............   ......................................cXN
NXc........';;,'............................................................................  ...  ...................................   ......................       ..    .                                                           ........   ..............  ......................................cXN
NXc.....................................................................................      ..   ....  .............................  ....................     ....                                                                          ...    ..........   ......................................cXN
NXc.....................................................................................     .................. ......................   ..................   .   ..                                                                            ...    .......     ......................................cXN
NXc.....................................................................................    ..... ....  ....... ........ ..... .......   .............   .                                                                                               ....       .....................................cXN
NXc.....................................................................................  ......  .............  .................  ...  .......                                              ........       ...                                             .. ..  .....................................cXN
NXc.................................................................................... ..... .......                 .    .   ...  ...  ......                                          ........ ....    .... ...   ..  ...........                            .   .....................................cXN
NXc................................................................................... ....                                      .      ..','.                        .....   ......       ..... ....     ........       ..     ..........                          .....................................cXN
NXc.................................................................................                                                   .,ldl,.                 ..............................    ...     ..............   ... ........... ..                        .....................................cXN
NXc..............................................................................   ...                                              ..;okxc..    ............................................  ..      ...............   ...  .....................  .             .....................................cXN
NXc.............................................................................                    ....  ...   ........ ....        .;okko,.  ... ...........................................         ................   ...  .....................  . .....       .....................................cXN
NXc...........................................................................                   ..... ........  ......  .....  ..  ..;oxd:..   ..............................................         ............................................. ........  ...  .....................................cXN
NXc.........................................................................                        .............................   ..,:c:'.... ..................................           ...       ..........................................................   .....................................cXN
NXc.......................................................................                  ....    ..........................  ...',,:::'. .....................................        .......     ........    ................................................   .....................................cXN
NXc.....................................................................          .          .........................   ....   ..,;,,'........  ................     ..........        ...          .  .....    .................................................  .....................................cXN
NXc...................................................................           .      ......  ......................   ....   ......  ....   .................      ..........       ...  .       ..      ...  .................................................  .....................................cXN
NXc.................................................................        ....          .....   ...   .............     ..   ..''.. ......  .................       ..........       ...  ..    ...       ......................................................  .....................................cXN
NXc................................................................    .......       ...........  ....  ....................  .';,.. ..   ......................        ........                  ..   ..................................................................................................cXN
NXc..............................................................   ......         .............  ..................... ......,;,.. .   .  .......................      .........        ....      .  ...........................................  ................. ....................................cXN
NKc............................................................     ..   .        .....   ........ ................  ..    ..,;,.. .................................     ...........   .....         ..  .......................................    ...............  ....................................cXN
NXc..........................................................    .... ...       .  ...     ..   ..  ..............   ... ...;;'......... ...................................................         ..  .......................................    ..........  ...   ...................................cXN
NXc......................................  ................     ........      .......    ...........   ...........   ..  .'::'. ....      .................................................      ...........................................................     ...  ...................................cXN
NXc....................................    ...............     ...           .......        ........   ..................,cc,.   ..       .................................................     ...........................................................     ....  ...................................cXN
NXc....................................    ..............   .  ....          .........        ..    ...............  ...,lo;..  .........................................................       ................................   .........................     ...  ...................................cXN
NXc...................................      ............   ..  .....      ......     ..      ....................... ..,lo:.. ........................................................... .    .......   ................    ...   ..........................      .  ...................................cXN
NXc.................................        ..........    .........      ......    .....  ............................,ldc'. .......................................................  .....    ........  ..............................  .....................   ...  ...................................cXN
NXc................................         .........    ...  ....      ..... .. .................................. .'cdl'. ..............................................................     ........................................  ...........................   ....  ............................cXN
NXc...............................          .......   ...........     .......    .....  .............................:do;. ..............................................................      .....................................................................   ....  ............................cXN
NXc..............................           ......   ..........      ......... ..............   ....................,lxl'. ....      ...... ..............     ...........................    .. ............     ..................................................  .....  ............................cXN
NXc..............................           ......    ....  ..      .... ...........................................;dd:.. ..           ..   ............        .........................    .. .............    ..................................................   ..................................cXN
NXc................................         .....      .......     .................................................:dd;.  .   ....    .... ... .........        .........................    .........................  ...........    .............  ..............  ..................................cXN
NXc................................         ....   ..  ......     .................................................'cxo,.  ..  .  .........................     ..........................    ......................................    .............  ........... ..  ..................................cXN
NXc................................        ....    .. ......      ............................................ ....'ldl'. ...    ...........................  ............................    ........................................  ............    ...........     .................................cXN
NXc.................................      .....   ...   ...      ..........................................   .....,ldc.. ...  ....   ....................................................     ......................................................   ...........     .................................cXN
NXc.................................     .....   .....  ....    ............................   ............ .......,ld:............   .....................................................    .......................................................  ..........      .................................cXN
NXc................................     ......   .  ... ...     ............................   ............. ......,lo:.  ........... .....................................................    ...........    ................................    ...............       .................................cXN
NXc...............................    ........      ... ...     .......      ....  .............................. .'cdc.. .................................................................    .........    ....................................................        .................................cXN
NXc...............................   .........   ...........    .....           .  .............................. ..cdo,. ..........       ................................................    ................................................................          ................................cXN
NXc.............................   ...........    ..........    ....               ...    ..........................:xd;............       ................................................    .......................................... ...................            ................................cXN
NXc...........................   .............    ..........     ....             ....    ..........................;dxc.............           ...........................................     ...........................................................           .  ................................cXN
NXc.........................   ...............     .........      ......    ...........  ...........................,oxo,. .. .......   ...... .............................................    .........................................................           ...  ................................cXN
NXc...........................................       ........     ...................................................:dd:. ..................................................................   .........................................................         .....   ...............................cXN
NXc............................................      .........    ...................................................,ldl'...................................................................    ...............     ...................................................   ..............................cXN
NXc............................................        .......     ...................................................;od:....................................................................   ..............        .................................................   ..............................cXN
NXc............................................         .......     ..................................................'cdl'...................................................................   ..............      .....................................................     ..........................cXN
NXc.........................................',;,.        .......    ...................................................,lo:...................................................................    ...........................................................................  ..........................cXN
NXc......................................',:okOkl'         ......    ...................................................;oo,...................................................................    ...........................................................................  .........................cXN
NXc....................................,:ok0KKXKkc.          ......   ...................................................:oc'...................................................................   ...........................................................................  .........................cXN
NXc.................................';lxOKKXXKXXKkc.         .......   ..................................................'cl;...................................................................   ............................................................................ .........................cXN
NXc..............................',:ok0KXXKXXXXXKKOl'.        ......    ..................................................,cl'..................................................................    .....................................................................................................cXN
NXc............................';lxOKXXXKKKXXXXXKKKOo'.         ......    .................................................;c:...................................................................    ....................................................................................................lXN
NXl..'...'''''''..''''...'''';cok0XXXXXXXXXXXXXXXXXX0d;.        ............................................................:c;........................................................................................................................................................''..''.....''.....lXN
NN0kkkkkkkkkkkkkkkkkkkkkkkkkO0XNNNNNNNNNNNNNNNNNNNNNNX0kddddddddxxxxxxxxdxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxk0Okxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkkkkkkkkkkkkkkkkkkkkk0NN
XNNNNNNNWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWNNNNNNNWWNNNNNNWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWNNX

";

        public static string KV2Description = @"

                         _  ___   _      ___  
                        | |/ / \ / | __ (_  |                                          
                        |   <`\ V /'|__| / /                                              
                        |_|\_\ \_/      |___|                                           Stats: 
                                                                                
Short from Kliment Voroshilov. Soviet heavy assault tank.                       Speed:                  10      
Due to the size of it’s turret and gun and it‘s large siloute,                  HP:                     200
the KV-2 was much slower KV-1 but has more firepower and is more durable.       Bullet speed:           100                                                                    
";
        public static string KV1Description = @"
                         _  ___   _      __  
                        | |/ / \ / | __ /  | 
                        |   <`\ V /'|__|`7 |                                                
                        |_|\_\ \_/       |_|                                                Stats:
                                                                                
Short for Kliment Voroshilov. Soviet heavy tank, named after                    Speed:                  15             
the Soviet defense commissar and politician Kilment Voroshilov.                 HP:                     150
It's faster than KV-2 but is less durable and has less firepower.               Bullet speed:           100
";

        public static string Title = @"
 _______    ______  ________  ________  __        ________         ______   ________         ______  ________   ______   __        ______  __    __   ______   _______    ______   _______  
|       \  /      \|        \|        \|  \      |        \       /      \ |        \       /      \|        \ /      \ |  \      |      \|  \  |  \ /      \ |       \  /      \ |       \ 
| $$$$$$$\|  $$$$$$\\$$$$$$$$ \$$$$$$$$| $$      | $$$$$$$$      |  $$$$$$\| $$$$$$$$      |  $$$$$$\\$$$$$$$$|  $$$$$$\| $$       \$$$$$$| $$\ | $$|  $$$$$$\| $$$$$$$\|  $$$$$$\| $$$$$$$\
| $$__/ $$| $$__| $$  | $$      | $$   | $$      | $$__          | $$  | $$| $$__          | $$___\$$  | $$   | $$__| $$| $$        | $$  | $$$\| $$| $$ __\$$| $$__| $$| $$__| $$| $$  | $$
| $$    $$| $$    $$  | $$      | $$   | $$      | $$  \         | $$  | $$| $$  \          \$$    \   | $$   | $$    $$| $$        | $$  | $$$$\ $$| $$|    \| $$    $$| $$    $$| $$  | $$
| $$$$$$$\| $$$$$$$$  | $$      | $$   | $$      | $$$$$         | $$  | $$| $$$$$          _\$$$$$$\  | $$   | $$$$$$$$| $$        | $$  | $$\$$ $$| $$ \$$$$| $$$$$$$\| $$$$$$$$| $$  | $$
| $$__/ $$| $$  | $$  | $$      | $$   | $$_____ | $$_____       | $$__/ $$| $$            |  \__| $$  | $$   | $$  | $$| $$_____  _| $$_ | $$ \$$$$| $$__| $$| $$  | $$| $$  | $$| $$__/ $$
| $$    $$| $$  | $$  | $$      | $$   | $$     \| $$     \       \$$    $$| $$             \$$    $$  | $$   | $$  | $$| $$     \|   $$ \| $$  \$$$ \$$    $$| $$  | $$| $$  | $$| $$    $$
 \$$$$$$$  \$$   \$$   \$$       \$$    \$$$$$$$$ \$$$$$$$$        \$$$$$$  \$$              \$$$$$$    \$$    \$$   \$$ \$$$$$$$$ \$$$$$$ \$$   \$$  \$$$$$$  \$$   \$$ \$$   \$$ \$$$$$$$                                                                                                                                                                                            
";

        public static string Play = @"
 _______   __         ______  __      __ 
|       \ |  \       /      \|  \    /  \
| $$$$$$$\| $$      |  $$$$$$\\$$\  /  $$
| $$__/ $$| $$      | $$__| $$ \$$\/  $$ 
| $$    $$| $$      | $$    $$  \$$  $$  
| $$$$$$$ | $$      | $$$$$$$$   \$$$$   
| $$      | $$_____ | $$  | $$   | $$    
| $$      | $$     \| $$  | $$   | $$    
 \$$       \$$$$$$$$ \$$   \$$    \$$                                   
";

        public static string SelectTank = @"
  ______   ________  __        ________   ______  ________        ________   ______   __    __  __    __ 
 /      \ |        \|  \      |        \ /      \|        \      |        \ /      \ |  \  |  \|  \  /  \
|  $$$$$$\| $$$$$$$$| $$      | $$$$$$$$|  $$$$$$\\$$$$$$$$       \$$$$$$$$|  $$$$$$\| $$\ | $$| $$ /  $$
| $$___\$$| $$__    | $$      | $$__    | $$   \$$  | $$            | $$   | $$__| $$| $$$\| $$| $$/  $$ 
 \$$    \ | $$  \   | $$      | $$  \   | $$        | $$            | $$   | $$    $$| $$$$\ $$| $$  $$  
 _\$$$$$$\| $$$$$   | $$      | $$$$$   | $$   __   | $$            | $$   | $$$$$$$$| $$\$$ $$| $$$$$\  
|  \__| $$| $$_____ | $$_____ | $$_____ | $$__/  \  | $$            | $$   | $$  | $$| $$ \$$$$| $$ \$$\ 
 \$$    $$| $$     \| $$     \| $$     \ \$$    $$  | $$            | $$   | $$  | $$| $$  \$$$| $$  \$$\
  \$$$$$$  \$$$$$$$$ \$$$$$$$$ \$$$$$$$$  \$$$$$$    \$$             \$$    \$$   \$$ \$$   \$$ \$$   \$$                                                                                                      
";

        public static string Exit = @"
 ________  __    __  ______  ________ 
|        \|  \  |  \|      \|        \
| $$$$$$$$| $$  | $$ \$$$$$$ \$$$$$$$$
| $$__     \$$\/  $$  | $$     | $$   
| $$  \     >$$  $$   | $$     | $$   
| $$$$$    /  $$$$\   | $$     | $$   
| $$_____ |  $$ \$$\ _| $$_    | $$   
| $$     \| $$  | $$|   $$ \   | $$   
 \$$$$$$$$ \$$   \$$ \$$$$$$    \$$                                   
";

        public static string Pointer = @"
 __    
|  \   
 \$$\  
  \$$\ 
   >$$\
  /  $$
 /  $$ 
|  $$  
 \$$   
       
       
       
";

        public static string MenuTank = @"
                      .,0X:. .;,;:;''...':,.                
                 .;oxkOKWWKOO0XKXXXXX0OOKNXOl.              
            ...'cOWMMMMMMMMMMMMMMMMMMMMMMMMMX:              
xxxxxxxxxxxkKNNNWMMMMMMMMMMMMMMMMMMMMMMMMMMMNc              
:::::::::::lKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNl              
            ;kOO0NMMMMMMMMMMMMMMMMMMMMMMMMMMNc              
                .kWMMMMMMMMMMMMMMMMMMMMMMMMMO'              
           ..   .lNMMMMMMMMMMMMMMMWK0XXXNNXOo'..            
       ...lKKOOOOXWMMMMMMMMMMMMMMMWK0NWMMMWNXKKKkxkkkxdolc,.
  .codk0KXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNo
 ,OWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKl
oKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0
l0XNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW
 .o0NXKXWMMMMWXNMMMMMNKNMMMMMWNKXWMMMMWWWMMMMWWMMMMMWKXWWWXd
   .:lokNWMMWOcxNWMMWx;lXWMMW0o::0WMMMKx0WMMMXOKWMMWXxodo:. 
      'lOXWWN0dkXNWWNOdxKNWWN0kdd0XWWNKx0NWWWKk0NWNKx:'.";

        public static string KV2 = @"
      _________
     |         |_
     |_         _|=====
  _____|_______|___
 /O    O     O    O\
 \O___O___O___O___O/";

        public static string KV1 = @"
        _______
       /       \====
  _____|_______/___
 /O    O     O    O\
 \O___O___O___O___O/";

        public static string Panzer = @"
        ________
=======|    +   |
   ___|__________\_
  /O    O     O   O\
  \O__O__O__O__O__O/";
        public static string Tree = @"
        1 1111 1111
    111 0010111 001111
    110010 0000110 0110 1
    111  0011100 00 1 111
11_0_10 011 0 10111 0 1111
11 1111 1 0 10 0  1111 11011
  1  111   000111   111
            0 00
            000      
            000
            000
       000 0000 0
      0     00   0
            0

      (binary tree)
";
    }
}