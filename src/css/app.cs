@import "https://fonts.googleapis.com/css?family=Open+Sans:400,800&display=swap";
/* http://meyerweb.com/eric/tools/css/reset/ 
   v2.0 | 20110126
   License: none (public domain)
*/
html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed,
figure, figcaption, footer, header, hgroup,
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline;
}

/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure,
footer, header, hgroup, menu, nav, section {
  display: block;
}

body {
  line-height: 1;
}

ol, ul {
  list-style: none;
}

blockquote, q {
  quotes: none;
}

blockquote:before, blockquote:after,
q:before, q:after {
  content: "";
  content: none;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

@font-face {
  font-family: "untitled-font-1";
  src: url("fonts/untitled-font-1.eot");
  src: url("fonts/untitled-font-1.eot?#iefix") format("embedded-opentype"), url("fonts/untitled-font-1.woff") format("woff"), url("fonts/untitled-font-1.ttf") format("truetype"), url("fonts/untitled-font-1.svg#untitled-font-1") format("svg");
  font-weight: normal;
  font-style: normal;
}
[data-icon]:before {
  font-family: "untitled-font-1" !important;
  content: attr(data-icon);
  font-style: normal !important;
  font-weight: normal !important;
  font-variant: normal !important;
  text-transform: none !important;
  speak: none;
  line-height: 1;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

[class^=icon-]:before,
[class*=" icon-"]:before {
  font-family: "untitled-font-1" !important;
  font-style: normal !important;
  font-weight: normal !important;
  font-variant: normal !important;
  text-transform: none !important;
  speak: none;
  line-height: 1;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

.icon-paper-plane:before {
  content: "a";
}

.icon-mouse-pointer:before {
  content: "b";
}

.icon-upload-cloud:before {
  content: "c";
}

.icon-download:before {
  content: "d";
}

.icon-upload:before {
  content: "e";
}

.icon-picture-streamline:before {
  content: "f";
}

body {
  font-family: "Open Sans", sans-serif;
  background-image: url("../images/background.svg");
  color: #96a3bb;
  font-size: 13px;
}

a {
  color: #1b65f6;
  text-decoration: none;
}

* {
  box-sizing: border-box;
}

.app-layout {
  max-width: 1000px;
  margin: 0;
}

@media (min-width: 992px) {
  .app-layout {
    padding: 100px 50px 50px 50px;
  }
}
.app-container {
  position: relative;
  overflow: hidden;
  padding: 20px 0 0 0;
  display: flex;
}

@media (min-width: 992px) {
  .app-container .app-header {
    float: right;
    padding-top: 100px;
    text-align: left;
  }

  .app-container .app-content {
    float: left;
  }
}
.app-container .app-header {
  padding-bottom: 10px;
  text-align: center;
  position: absolute;
  right: 10%;
}

.app-container .app-header .app-site-info {
  color: #FFFFFF;
}

.app-container .app-header .app-site-info h1 {
  margin: 0;
  padding: 0;
  font-size: 45px;
  font-weight: 700;
}

@media (max-width: 768px) {
  .app-container .app-header .app-site-info h1 {
    position: relative;
    font-size: 20px;
  }
}
.app-container .app-header .app-site-info .site-title {
  margin: 0 0 0 0;
  padding: 0;
  font-size: 50px;
  font-weight: 300;
  color: rgba(255, 255, 255, 0.9);
}

@media (max-width: 768px) {
  .app-container .app-header .app-site-info .site-title {
    display: none;
  }
}
.app-container .app-header .app-site-info .site-slogan {
  margin-top: 5px;
  padding: 0;
  font-size: 30px;
  font-weight: 300;
  color: rgba(255, 255, 255, 0.6);
}

@media (max-width: 768px) {
  .app-container .app-header .app-site-info .site-slogan {
    display: none;
  }
}
.app-container .app-content {
  background: #FFFFFF;
  border-radius: 5px;
}

@media (min-width: 768px) {
  .app-container .app-content {
    width: 350px;
  }
}
.app-card {
  background: #FFFFFF;
  border-radius: 5px;
}

@media (min-width: 768px) {
  .app-card {
    width: 350px;
  }
}
.app-card .app-card-header {
  overflow: hidden;
  border-radius: 5px;
  position: relative;
  background: #f3f7ff;
}

.app-card .app-card-header .app-card-header-inner {
  padding: 20px;
}

.app-card .app-card-content .app-card-content-inner {
  padding: 20px;
}

.app-card.app-card-upload .app-card-content-inner, .app-card.app-card-upload-sent .app-card-content-inner {
  padding: 30px;
}

.app-folder-select-zone {
  width: 100%;
  display: block;
  margin-bottom: 10px;
  text-align: center;
}

.app-file-select-zone {
  width: 100%;
  display: block;
  margin-bottom: 20px;
  text-align: center;
}

.app-file-select-zone label {
  display: block;
  width: 100%;
}

.app-folder-select-zone label {
  display: block;
  width: 100%;
}

.app-file-select-zone label input {
  position: fixed;
  top: -9999px;
}

.app-folder-select-zone label input {
  position: fixed;
  top: -9999px;
}

.app-file-select-zone .app-upload-description {
  font-size: 12px;
  display: block;
}

.app-file-select-zone .app-upload-icon {
  display: inline-block;
  margin-bottom: 10px;
  width: 60px;
  height: 30px;
  border: 1px dashed #96a3bb;
  position: relative;
}

.app-folder-select-zone-inner {
  display: inline-block;
  width: 80%;
  height: 30px;
  text-align: center;
}

.app-folder-select-zone .app-upload-icon-2 {
  display: block;
  margin: 0 10px 0 10px;
  position: relative;
}

.app-folder-select-zone .app-upload-icon-2 i {
  position: relative;
  font-size: 20px;
  cursor: pointer;
}

.app-upload-description-folder {
  font-size: 12px;
}

.app-file-select-zone .app-upload-icon i {
  position: absolute;
  left: 10px;
  top: -10px;
  background: #f3f7ff;
  font-size: 25px;
  cursor: pointer;
}

.app-file-select-zone.error .app-upload-icon {
  border-color: #d0152e;
}

.app-form-item {
  margin: 0 0 15px 0;
}

.app-form-item label {
  display: block;
  text-transform: uppercase;
  font-weight: 400;
  margin: 0 0 8px 0;
}

.app-form-item input[type=text], .app-form-item input[type=email], .app-form-item input[type=password], .app-form-item textarea {
  width: 100%;
  border: 1px solid #e0e0e0;
  outline: 0 none;
  border-radius: 5px;
  padding: 8px;
}

.app-form-item input[type=text]:focus, .app-form-item input[type=text] :active, .app-form-item input[type=email]:focus, .app-form-item input[type=email] :active, .app-form-item input[type=password]:focus, .app-form-item input[type=password] :active, .app-form-item textarea:focus, .app-form-item textarea :active {
  outline: 0 none;
}

.app-form-item textarea {
  min-height: 50px;
}

.app-form-item.error input {
  border-color: #d0152e;
  color: #d0152e;
  text-decoration-color: #d0152e;
}

.app-form-actions .app-button {
  width: 100%;
  background: #FFFFFF;
  text-align: center;
  display: block;
  font-weight: 700;
  color: #1b65f6;
  border: 1px solid #1b65f6;
  border-radius: 5px;
  text-transform: uppercase;
  padding: 10px 15px;
  z-index: 1000;
}

.app-form-actions .app-button.primary {
  background: #1b65f6;
  color: #FFFFFF;
}

.app-files-selected {
  max-height: 150px;
  position: relative;
  overflow-y: auto;
  background: #FFFFFF;
  position: relative;
  margin: -20px -20px 20px -20px;
  padding: 10px;
}

.app-files-selected .app-file-selected-item {
  display: flex;
  border-bottom: 1px solid rgba(0, 0, 0, 0.09);
  padding: 10px 0;
}

.app-files-selected .app-file-selected-item .file-name {
  flex-grow: 1;
  padding-top: 4px;
}

.app-files-selected .app-file-remove {
  border: 0 none;
  padding: 3px;
  font-size: 14px;
  font-weight: 300;
  background: none;
}

.text-uppercase {
  text-transform: uppercase;
}

.error {
  color: #d0152e;
}

.app-home-upload-icon {
  display: block;
  text-align: center;
}

.app-home-upload-icon i {
  font-size: 50px;
  display: inline-block;
  border: 1px solid #96a3bb;
  width: 100px;
  height: 100px;
  border-radius: 50%;
  line-height: 100px;
}

.app-home-upload-icon h2 {
  font-size: 17px;
  margin: 20px 0 0 0;
  padding: 0;
}

.app-home-upload-sent-icon {
  display: block;
  text-align: center;
}

.app-home-upload-sent-icon i {
  font-size: 50px;
  display: inline-block;
  border: 1px solid #96a3bb;
  width: 100px;
  height: 100px;
  border-radius: 50%;
  line-height: 100px;
}

.app-total-files-uploaded {
  margin-top: 20px;
}

.app-state-uploads {
  display: flex;
  flex-direction: row;
}

.app-state-uploads .app-state-uploads-left {
  flex-grow: 1;
}

.app-progress {
  background: #f1f8fe;
  border: 1px solid #b2d8f8;
  height: 15px;
  line-height: 15px;
  width: 100%;
  border-radius: 10px;
  margin: 10px 0 10px 0;
  position: relative;
  overflow: hidden;
}

.app-progress .app-progress-bar {
  position: absolute;
  left: 0;
  top: 0;
  line-height: 15px;
  background: #1b65f6;
  height: 15px;
  display: block;
}

.app-button {
  margin-top: 15px;
}

.app-text-center {
  text-align: center;
}

.app-upload-sent-message h2 {
  font-size: 25px;
  font-weight: 400;
  padding: 0;
  margin: 20px 0;
}

.app-upload-sent-message p {
  line-height: 1.5em;
}

.app-upload-sent-actions {
  margin: 20px 0 0 0;
}

.app-upload-sent-actions button {
  margin: 10;
}

.app-page-download .app-top-header {
  text-align: center;
  color: white;
  margin-bottom: 20px;
  cursor: pointer;
}

.app-page-download .app-top-header h1 {
  margin: 0;
  padding: 0;
  font-size: 40px;
  font-weight: 700;
}

.app-page-download .app-card {
  margin: 0 auto;
}

@media (min-width: 768px) {
  .app-page-download .app-card {
    width: 400px;
  }
}
.app-download-icon {
  text-align: center;
}

.app-download-icon i {
  font-size: 60px;
  color: #96a3bb;
  display: inline-block;
  border: 1px solid #96a3bb;
  width: 100px;
  height: 100px;
  border-radius: 50%;
  line-height: 100px;
}

.app-download-message {
  margin-top: 30px;
}

.app-download-message h2 {
  font-size: 20px;
  margin: 20px 0;
}

.app-download-message ul {
  list-style: none;
  margin: 0;
  padding: 0;
}

.app-download-message li {
  margin: 0 10px 0 0;
  padding: 0 0 0 10px;
  display: inline-block;
  position: relative;
}

.app-download-message li:before {
  position: absolute;
  top: 5px;
  left: 0;
  display: block;
  content: "";
  width: 4px;
  height: 4px;
  background: #96a3bb;
  border-radius: 50%;
}

.app-download-message li:first-child {
  padding: 0;
}

.app-download-message li:first-child:before {
  display: none;
}

.app-download-file-list {
  margin: 10px;
}

.app-download-file-list .app-download-file-list-item {
  display: flex;
  border-bottom: 1px solid #e3eaf8;
  padding: 10px 0;
}

.app-download-file-list .app-download-file-list-item .filename {
  flex-grow: 1;
}

.app-download-file-list .app-download-file-list-item .download-action a {
  color: #1b65f6;
  text-decoration: none;
}

.app-download-actions button {
  margin: 10px 0;
}

.app-nav-bar {
  height: 50px;
  height: 50px;
  position: fixed;
  margin: 15px 0 0 0;
  width: 100%;
  right: 0;
  top: 0;
  z-index: 1000;
  color: #FFFFFF;
  min-width: 260px;
}

.app-nav-bar .app-nav-bar-inner {
  display: flex;
  position: fixed;
  margin: 0 auto;
  width: 1250px;
}

.app-nav-bar .app-nav-bar-left {
  flex-grow: 1;
  left: 0;
}

.app-nav-bar .app-nav-bar-left i {
  line-height: 50px;
  margin-left: 20px;
  font-size: 25px;
  cursor: pointer;
}

.app-nav-bar .app-nav-bar-right {
  right: 0;
  right: 0;
  text-align: right;
}

.app-nav-bar .app-nav-bar-right .app-nav-bar-right-inner {
  display: flex;
}

.app-nav-bar .app-nav-bar-right .app-nav-bar-right-inner ul {
  float: right;
  right: 0;
  border-radius: 10px;
  overflow: hidden;
  background: rgba(0, 0, 0, 0.466);
  height: 40px;
}

.app-nav-bar .app-nav-bar-right .app-nav-bar-right-inner ul li {
  color: #96a3bb;
  padding: 10px 15px 0 15px;
  font-size: 16px;
  font-weight: 500;
}

.app-nav-bar .app-nav-bar-right .app-nav-bar-right-inner ul li:hover {
  background: rgba(5, 0, 0, 0.5);
  transition-duration: 0.3s;
  transition-delay: 0s;
}

.app-nav-bar .app-nav-bar-right .app-nav-bar-right-inner .user-profile-menu {
  list-style: none;
  display: flex;
}

.app-nav-bar .app-nav-bar-right .app-nav-bar-right-inner .user-profil-img {
  padding-top: 5px;
}

.app-nav-bar .app-nav-bar-right .app-nav-bar-right-inner .user-profil-img img {
  width: 40px;
  height: 40px;
  border-radius: 50%;
}

.app-right-components {
  background: #FFFFFF;
  z-index: 1001;
  position: fixed;
  right: 0;
  top: 0;
  bottom: 0;
  overflow-y: auto;
}

.app-right-components .form-title {
  font-size: 30px;
  text-align: center;
  padding: 10px 0;
  line-height: 50px;
  font-weight: 500;
  text-align: center;
  display: block;
}

.app-right-components .app-login-form-inner {
  position: relative;
  padding: 40px;
}

.app-form-actions .app-form-forgotten-pass {
  margin-top: 5px;
  text-align: center;
}

.app-form-actions .app-form-forgotten-pass a {
  text-decoration: underline;
  color: #96a3bb;
}

.app-form-actions .app-form-forgotten-pass a.hover {
  color: white;
}

.app-close-button {
  border-radius: 50%;
  width: 30px;
  height: 30px;
  z-index: 1002;
  color: #bdbbbb;
  background: white;
  border: 2px solid #bdbbbb;
  margin: 10px 0 0 10px;
  font-weight: 800;
  padding: 2px 0px 5px 0px;
}

.app-close-button:hover {
  border-radius: 50%;
  color: #a3a3a3;
  border: 2px solid #a3a3a3;
}

.user-signin-button {
  cursor: pointer;
}

.app-subscribe-component {
  min-width: 1000px;
}

.app-form-subscribe-item {
  margin: 0 0 15px 0;
  text-align: center;
}

.app-form-subscribe-item-search-filter {
  width: 100%;
  border: 1px solid #e0e0e0;
  outline: 0 none;
  border-radius: 5px;
  padding: 8px;
  min-height: 40px;
}

.autocomplete-country {
  width: 100%;
}

.autocomplete-country input {
  width: 100%;
}

.autocomplete-country ul {
  border: 1px solid #e0e0e0;
  border-radius: 5px;
  margin: 1px 0 0 0;
  max-height: 150px;
  overflow: auto;
  list-style-type: none;
  text-align: left;
}
.autocomplete-country ul li {
  cursor: pointer;
  padding: 10px;
  position: relative;
  z-index: 1000;
}
.autocomplete-country ul li:hover {
  background: #1b65f6;
  color: #FFFFFF;
}

.app-form-subscribe-item input[type=text], .app-form-subscribe-item input[type=email], .app-form-subscribe-item input[type=password], .app-form-subscribe-item textarea {
  width: 100%;
  border: 1px solid #e0e0e0;
  outline: 0 none;
  border-radius: 5px;
  padding: 8px;
  min-height: 40px;
}

.app-form-subscribe-item input[type=text]:focus, .app-form-subscribe-item input[type=text] :active, .app-form-subscribe-item input[type=email]:focus, .app-form-subscribe-item input[type=email] :active, .app-form-subscribe-item input[type=password]:focus, .app-form-subscribe-item input[type=password] :active, .app-form-subscribe-item textarea:focus, .app-form-subscribe-item textarea :active {
  outline: 0 none;
}

.app-form-subscribe-item .email-error {
  margin: 3px 0 0 0;
  border-radius: 5px;
  height: 30px;
  width: 51%;
  display: flex;
  background-color: #e20926c7;
  padding: 8px 0 0 0;
}
.app-form-subscribe-item .email-error p {
  margin: 0 0 0 10px;
  display: inline-block;
  color: #FFFFFF;
  font-weight: 500;
}

.app-form-subscribe .radio-buttons {
  display: inline-flex;
  margin: 0 0 10px 0;
}
.app-form-subscribe .radio-buttons h2 {
  margin: 0 0 10px 0;
  font-size: 30px;
  font-weight: 600;
  font-style: italic;
  padding: 40px 0 0 0;
}
.app-form-subscribe .radio-buttons p {
  font-size: 25px;
  color: black;
  margin: 0 0 30px 0;
}
.app-form-subscribe .radio-buttons .billing {
  font-size: 12px;
  font-family: sans-serif;
  font-weight: 500;
}

.radio-button-inner-left input, .radio-button-inner-right input {
  width: 200px;
  height: 200px;
}

.radio-button-inner-left-after input, .radio-button-inner-right-after input {
  width: 200px;
  height: 200px;
}

.app-form-subscribe .radio-button-inner-left {
  width: 200px;
  height: 200px;
  padding: 10px;
  position: relative;
  display: block;
  margin: 0 15px 0 0;
  border-radius: 5px;
  background: #e7e7e7;
}

.app-form-subscribe .radio-button-inner-left:hover, .radio-button-inner-right:hover {
  cursor: pointer;
}

.app-form-subscribe .radio-button-inner-right {
  width: 200px;
  height: 200px;
  padding: 10px;
  position: relative;
  display: block;
  border-radius: 5px;
  background: #e7e7e7;
}

.app-form-subscribe .radio-button-inner-right:hover {
  cursor: pointer;
}

.radio-button-left {
  display: flex;
}
.radio-button-left input {
  width: 20px;
  height: 20px;
}

.app-form-subscribe .radio-buttons .radio-button-inner-left-after {
  width: 200px;
  height: 200px;
  padding: 10px;
  position: relative;
  display: block;
  color: #FFFFFF;
  margin: 0 15px 0 0;
  border-radius: 5px;
  background: #7a1414;
  transition-duration: 0.5s;
  transition-delay: 0s;
}
.app-form-subscribe .radio-buttons .radio-button-inner-left-after h2 {
  margin: 0 0 10px 0;
  font-size: 30px;
  font-weight: 600;
  font-style: italic;
  padding: 40px 0 0 0;
}
.app-form-subscribe .radio-buttons .radio-button-inner-left-after p {
  font-size: 25px;
  color: white;
  margin: 0 0 30px 0;
}
.app-form-subscribe .radio-buttons .radio-button-inner-left-after .billing {
  font-size: 12px;
  font-family: sans-serif;
  font-weight: 500;
}

.app-form-subscribe .radio-buttons .radio-button-inner-right-after {
  width: 200px;
  height: 200px;
  padding: 10px;
  position: relative;
  display: block;
  color: #FFFFFF;
  border-radius: 5px;
  transition-duration: 0.5s;
  transition-delay: 0s;
  background: #7a1414;
}
.app-form-subscribe .radio-buttons .radio-button-inner-right-after h2 {
  margin: 0 0 10px 0;
  font-size: 30px;
  font-weight: 600;
  font-style: italic;
  padding: 40px 0 0 0;
}
.app-form-subscribe .radio-buttons .radio-button-inner-right-after p {
  font-size: 25px;
  color: white;
  margin: 0 0 30px 0;
}
.app-form-subscribe .radio-buttons .radio-button-inner-right-after .billing {
  font-size: 12px;
  font-family: sans-serif;
  font-weight: 500;
}

.app-form-subscribe .radio-buttons .radio-button-right {
  display: flex;
}
.app-form-subscribe .radio-buttons .radio-button-right input {
  width: 20px;
  height: 20px;
}

.app-form-subscribe-item.error input {
  border-color: #d0152e;
  color: #d0152e;
  text-decoration-color: #d0152e;
}

.app-form-subscribe {
  text-align: center;
  width: 50%;
  display: block;
  position: relative;
  margin: 5px auto;
}

.app-billing-header {
  font-size: 17px;
  margin: 25px 0 8px 0;
  font-weight: 500;
  display: block;
  text-align: left;
}

.app-subscribe-button {
  width: 60%;
  background: #FFFFFF;
  margin: 10px auto;
  text-align: center;
  display: block;
  font-weight: 500;
  color: #1b65f6;
  border: 1px solid #1b65f6;
  border-radius: 5px;
  text-transform: uppercase;
  padding: 10px 15px;
}

.app-subscribe-button.primary {
  background: #1b65f6;
  color: #FFFFFF;
}

.app-form-search-filter {
  position: relative;
  border: 1px solid black;
  display: flexbox;
  max-height: 40px;
  overflow-y: auto;
}

/*# sourceMappingURL=app.css.map */
/*# sourceMappingURL=app.scss.map */

/*# sourceMappingURL=app.cs.map */
