
using System.Runtime.CompilerServices;

#if SPECFLOW_ENABLE_STRONG_NAME_SIGNING
[assembly: InternalsVisibleTo("Reqnroll.TestProjectGenerator.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010059bb085601a8b65a8a7b00f34e6d85df230f1e4913d3c0eaadcd13c1fd9cd15c3f01567c49d5f41f617dbda6f544ea3e2d5b5a042f307a7c8d21a079254509ba543efaefce96fac977abd0a76206b721abc33f84ee45ae5383cf50eeb8e234595656fd4af916e1dcde644ce20bb9a68bd72bc7957b759560524c63ca294585ca")]
#else
[assembly: InternalsVisibleTo("Reqnroll.TestProjectGenerator.Tests")]
#endif