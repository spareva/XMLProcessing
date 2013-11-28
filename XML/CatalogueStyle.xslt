<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Catalogue</h1>
        <table bgcolor="E0E0E0" cellspacing="1" border="1">

          <tr bgcolor="#EEEEEE">
            <td>
              <b>Album Name</b>
            </td>
            <td>
              <b>DatArtist Namee</b>
            </td>
            <td>
              <b>Year</b>
            </td>
            <td>
              <b>Producer</b>
            </td>
            <td>
              <b>Price</b>
            </td>
            <td>
              <b>Song Name</b>
            </td>
            <td>
              <b>Song Duration</b>
            </td>
          </tr>

          <xsl:for-each select="/Catalogue/catalogue">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="/Catalogue/catalogue/name"/>
              </td>
              <td>
                <xsl:value-of select="/Catalogue/catalogue/artist"/>
              </td>
              <td>
                <xsl:value-of select="/Catalogue/catalogue/year"/>
              </td>
              <td>
                <xsl:value-of select="/Catalogue/catalogue/producer"/>
              </td>
              <td>
                <xsl:value-of select="/Catalogue/catalogue/price"/>
              </td>
              <td>
                <xsl:value-of select="/Catalogue/catalogue/song/title"/>
              </td>
              <td>
                <xsl:value-of select="/Catalogue/catalogue/song/duration"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>