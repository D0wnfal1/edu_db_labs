/**
 * Welcome to your Workbox-powered service worker!
 *
 * You'll need to register this file in your web app and you should
 * disable HTTP caching for this file too.
 * See https://goo.gl/nhQhGp
 *
 * The rest of the code is auto-generated. Please don't update this file
 * directly; instead, make changes to your Workbox build configuration
 * and re-run your build process.
 * See https://goo.gl/2aRDsh
 */

importScripts("https://storage.googleapis.com/workbox-cdn/releases/4.3.1/workbox-sw.js");

self.addEventListener('message', (event) => {
  if (event.data && event.data.type === 'SKIP_WAITING') {
    self.skipWaiting();
  }
});

/**
 * The workboxSW.precacheAndRoute() method efficiently caches and responds to
 * requests for URLs in the manifest.
 * See https://goo.gl/S9QRab
 */
self.__precacheManifest = [
  {
    "url": "404.html",
    "revision": "57ee5bb8ccf4f02a635f13ad705559e9"
  },
  {
    "url": "assets/css/0.styles.1e5a53e3.css",
    "revision": "e1675fee86bc6d1e693787c4d261d0d3"
  },
  {
    "url": "assets/img/1.4d4a4baa.png",
    "revision": "4d4a4baa35c929e132c7fa81505d85f6"
  },
  {
    "url": "assets/img/10.8a9607a5.png",
    "revision": "8a9607a514762fe6b2de610b016b4769"
  },
  {
    "url": "assets/img/11.077077b8.png",
    "revision": "077077b8f22ed90e2d440018309ca05d"
  },
  {
    "url": "assets/img/12.88d0d1f0.png",
    "revision": "88d0d1f0d34c088baebdf3415af3dad8"
  },
  {
    "url": "assets/img/13.f178990b.png",
    "revision": "f178990bef6d3009b67a7b2c5fd55c8a"
  },
  {
    "url": "assets/img/2.cd1b58b8.png",
    "revision": "cd1b58b8351af26f541dd958a9ca2440"
  },
  {
    "url": "assets/img/3.21eca765.png",
    "revision": "21eca765e8c55fc62c7f2f35b39d8f4e"
  },
  {
    "url": "assets/img/4.0d04dfc9.png",
    "revision": "0d04dfc9d188620b5514ddb1ebc9e2df"
  },
  {
    "url": "assets/img/5.f7e6db5b.png",
    "revision": "f7e6db5b6799fb5a4abd459158d41e06"
  },
  {
    "url": "assets/img/6.c121a2f0.png",
    "revision": "c121a2f0c976ac3453b01d3f856970d4"
  },
  {
    "url": "assets/img/7.da7734a6.png",
    "revision": "da7734a678920f9a0917c7797f1864b6"
  },
  {
    "url": "assets/img/8.c680761a.png",
    "revision": "c680761a6531fe60debc89fcf2f133f8"
  },
  {
    "url": "assets/img/diagram.a67680ce.png",
    "revision": "a67680ceb39725d20086b1fc788750d1"
  },
  {
    "url": "assets/img/search.83621669.svg",
    "revision": "83621669651b9a3d4bf64d1a670ad856"
  },
  {
    "url": "assets/js/1.94825421.js",
    "revision": "58495f2046c541ebde887c6938e398a7"
  },
  {
    "url": "assets/js/10.300a4899.js",
    "revision": "9f1c87b874beef3a41426822c2000507"
  },
  {
    "url": "assets/js/13.0cb61c15.js",
    "revision": "ac4f3fe749811b8e7322af0ac02b07a5"
  },
  {
    "url": "assets/js/14.88313f98.js",
    "revision": "63f65842352107ebcdc5131eb6eb5f67"
  },
  {
    "url": "assets/js/15.99633a4f.js",
    "revision": "86a28369a719249c9b78821ec49d13c9"
  },
  {
    "url": "assets/js/16.2bc577d7.js",
    "revision": "18e9a7b58be1e7e5f75822bfa14c22e0"
  },
  {
    "url": "assets/js/17.73179dfb.js",
    "revision": "6ee773ad2b1e627fc373a38edf339d64"
  },
  {
    "url": "assets/js/18.bbb3bd3c.js",
    "revision": "0f8fcc5459702246f890a0e38ffafda6"
  },
  {
    "url": "assets/js/19.9b8f087f.js",
    "revision": "324990ca660d7ed766a310931c2b5664"
  },
  {
    "url": "assets/js/2.4936aa70.js",
    "revision": "bd57bc512d6d3a7dd848b4514fa2d7ad"
  },
  {
    "url": "assets/js/20.0881a58f.js",
    "revision": "9a073e6670cdf9690eecbea52cb18553"
  },
  {
    "url": "assets/js/21.39425e04.js",
    "revision": "8b7c9b61e56f99d768ff23d21e9d935d"
  },
  {
    "url": "assets/js/22.d2077878.js",
    "revision": "9f6e9904ba0cfa4dc7bc50e47142a6e3"
  },
  {
    "url": "assets/js/23.3ec6ef11.js",
    "revision": "d0e91598f11e346698d9855ebb1cde0b"
  },
  {
    "url": "assets/js/24.30ee8832.js",
    "revision": "fb1b90eaebee01ee4a48a80fa33937cd"
  },
  {
    "url": "assets/js/25.9b82b3b9.js",
    "revision": "2e9bc8583fc2d0dfe0e546a919f8359a"
  },
  {
    "url": "assets/js/26.590bbba7.js",
    "revision": "263fdeb3a6421d841b88e0d0908be681"
  },
  {
    "url": "assets/js/27.82273840.js",
    "revision": "71f0804ba7e4bb9de95f7188d5605109"
  },
  {
    "url": "assets/js/28.37c300d2.js",
    "revision": "ea69ad43276941b19e99b7c9d4cd8d38"
  },
  {
    "url": "assets/js/29.0f027b3a.js",
    "revision": "24591ff2410c79551419409f8f0edf9b"
  },
  {
    "url": "assets/js/3.3a389e6a.js",
    "revision": "54c2d66a75926ab0b7e2caed46600a3e"
  },
  {
    "url": "assets/js/30.e2eb125b.js",
    "revision": "050ab8fc99232b7bed080ab80d5915c3"
  },
  {
    "url": "assets/js/31.3a82a6a6.js",
    "revision": "2101ad110e65731ddfb88da803578be2"
  },
  {
    "url": "assets/js/32.a1920feb.js",
    "revision": "57064f6d5b59f5873834709f59a013c0"
  },
  {
    "url": "assets/js/33.96dbef15.js",
    "revision": "a8161f6000fd5dd5154ca0b08011ab2f"
  },
  {
    "url": "assets/js/34.12d2583d.js",
    "revision": "a9b894f50031ba853ef71476f97cdb08"
  },
  {
    "url": "assets/js/35.707b89a6.js",
    "revision": "89cd2a48c82aec469300b771ff7db87b"
  },
  {
    "url": "assets/js/36.e9a95e6d.js",
    "revision": "319618f8ef1c6cb6b2b7545913c357bc"
  },
  {
    "url": "assets/js/37.e61c002f.js",
    "revision": "c0c282eed66a243b82b2d73f833124f7"
  },
  {
    "url": "assets/js/38.95d35231.js",
    "revision": "9c3abaef01c9e6c7248507cb67f8a0fe"
  },
  {
    "url": "assets/js/39.10ea4be4.js",
    "revision": "90faa2b82a4ba4d59f3233a9a2e5e908"
  },
  {
    "url": "assets/js/4.6f9e5ef2.js",
    "revision": "9f91741364315791b778c5e7303f1aab"
  },
  {
    "url": "assets/js/41.e16fbfde.js",
    "revision": "aeffda24886b51c5458301234e1778e9"
  },
  {
    "url": "assets/js/5.271a1bcd.js",
    "revision": "1df86a13c0bc7bf163c6642dab3e0227"
  },
  {
    "url": "assets/js/6.a49fc274.js",
    "revision": "21c5ea9a89e98a1d3f8c4c10d5259a1f"
  },
  {
    "url": "assets/js/7.221b49a3.js",
    "revision": "ea14a55f7691ae957d6b696e1afb1cb5"
  },
  {
    "url": "assets/js/8.d86237d5.js",
    "revision": "cd353fe1326ed329056965811eb36b5e"
  },
  {
    "url": "assets/js/9.a032969c.js",
    "revision": "053e8bc1e15890032d6d3866278ed63d"
  },
  {
    "url": "assets/js/app.1b2e2aef.js",
    "revision": "a55147e2562c2ca560ed7ee0aa40b098"
  },
  {
    "url": "assets/js/vendors~docsearch.8644e795.js",
    "revision": "16a84ce5ba6d1d5ec9cea7b74e6fe3e0"
  },
  {
    "url": "conclusion/index.html",
    "revision": "dc9f2f1f88581600f305edf921525bca"
  },
  {
    "url": "design/index.html",
    "revision": "e84b1dd305080a8393005fd8ee4b27ea"
  },
  {
    "url": "index.html",
    "revision": "961b59b1a671fcdd2e95fc515da6da3f"
  },
  {
    "url": "intro/index.html",
    "revision": "0bd68a42785456834dcb857b562052da"
  },
  {
    "url": "license.html",
    "revision": "70a2edbdcd1a16b29dc6ec11e14ab937"
  },
  {
    "url": "myAvatar.png",
    "revision": "b76db1e62eb8e7fca02a487eb3eac10c"
  },
  {
    "url": "requirements/index.html",
    "revision": "96e4b562ca4294cbd8f00e64730d8310"
  },
  {
    "url": "requirements/stakeholders-needs.html",
    "revision": "75427720a558be934d023b098d9a3ad9"
  },
  {
    "url": "requirements/state-of-the-art.html",
    "revision": "30624ddce6baa954c072b054ce659985"
  },
  {
    "url": "software/index.html",
    "revision": "452dfef89c68589baa00776e2013180f"
  },
  {
    "url": "test/index.html",
    "revision": "7f5d4f712e946b3856496e31f31fe58a"
  },
  {
    "url": "use cases/index.html",
    "revision": "6f28a2052fa0c2424a5c7602570e6ebc"
  }
].concat(self.__precacheManifest || []);
workbox.precaching.precacheAndRoute(self.__precacheManifest, {});
addEventListener('message', event => {
  const replyPort = event.ports[0]
  const message = event.data
  if (replyPort && message && message.type === 'skip-waiting') {
    event.waitUntil(
      self.skipWaiting().then(
        () => replyPort.postMessage({ error: null }),
        error => replyPort.postMessage({ error })
      )
    )
  }
})
